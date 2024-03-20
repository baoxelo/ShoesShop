using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoesShop.Models;

namespace ShoesShop.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly DatabaseContext _context;
        private readonly ILogger<CartController> _logger;
        public CartController(DatabaseContext context, UserManager<AppUser> userManager, ILogger<CartController> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;

        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            string userId = await _userManager.GetUserIdAsync(user);
            if (userId == null)
            {
                return NotFound("Khong tim thay tai khoan");
            }
            // Get Cart
            Cart? cart;
            cart = await _context.Carts.FirstOrDefaultAsync(q => q.AppUserId == userId);
            if (cart == null)
            {
                var newCart = new Cart()
                {
                    AppUserId = userId,
                    TotalPrice = 0,
                };
                await _context.Carts.AddAsync(newCart);
                await _context.SaveChangesAsync();
                cart = await _context.Carts.FirstOrDefaultAsync(q => q.AppUserId == userId);
                if (cart == null)
                {
                    return NotFound("Có lỗi xảy ra");
                }
            }
            cart.CartItems = await _context.CartItems.Where(q => q.CartId == cart.Id)
                                .Include(q => q.ProductItem)
                                    .ThenInclude(p => p.Size)
                                    .Include(q => q.ProductItem)
                                    .ThenInclude(p => p.Product)
                                    .ThenInclude(p => p.Discount)
                                    .ToListAsync();
            TempData["Cart"] = cart;
            return View(cart);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CheckOut(IFormCollection form)
        {
            // GET CART OF CURRENT USER
            Cart? cart;
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            string userId = await _userManager.GetUserIdAsync(user);
            if (userId == null)
            {
                return NotFound("Khong tim thay tai khoan");
            }
            // Get Cart
            cart = await _context.Carts.FirstOrDefaultAsync(q => q.AppUserId == userId);
            if (cart == null)
            {
                TempData["StatusMessage"] = "Bạn chưa có hàng trong giỏ";
                return View("Index");
            }
            cart.CartItems = await _context.CartItems.Where(q => q.CartId == cart.Id)
                                    .Include(q => q.ProductItem)
                                    .ThenInclude(p => p.Size)
                                    .Include(q => q.ProductItem)
                                    .ThenInclude(p => p.Product)
                                    .ToListAsync();
            if (cart.CartItems == null || cart.CartItems.Count < 1)
            {
                TempData["StatusMessage"] = "Bạn chưa có hàng trong giỏ";
                return View("Index", cart);
            }
            // HANDLE INVOICE
            var customerName = Convert.ToString(form["CustomerName"]);
            var address = Convert.ToString(form["Address"]);
            var phone = Convert.ToString(form["PhoneNumber"]);
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                ModelState.AddModelError("", "Vui lòng điền đầy đủ thông tin vào biểu mẫu.");
                return View("Index", cart);
            }
            var invoiceCode = await GenerateOrderNumber();
            Invoice newInvoice = new Invoice()
            {
                InvoiceCode = invoiceCode,
                AppUserId = userId,
                CustomerName = customerName,
                Address = address,
                Phone = phone,
                TotalPrice = 0,
                DateOrdered = DateTime.Now,
                StatusId = 1
            };
            _context.Invoices.Add(newInvoice);
            await _context.SaveChangesAsync();
            var invoice = await _context.Invoices.Where(q => q.InvoiceCode == invoiceCode).SingleOrDefaultAsync();
            if (invoice == null)
            {
                return NotFound("Invoice đã được tạo nhưng không thể lấy, lỗi server");
            }
            List<InvoiceItem> newInvoiceList = new List<InvoiceItem>();
            foreach (var item in cart.CartItems)
            {
                InvoiceItem invoiceItem = new InvoiceItem()
                {
                    ProductItemId = item.ProductItemId,
                    Quantity = item.Quantity,
                    InvoiceId = invoice.Id,
                    
                };
                newInvoiceList.Add(invoiceItem);
                invoice.TotalPrice += (item.ProductItem.Product.CurrentPrice ?? 0) * item.Quantity;
            }
            await _context.InvoiceItems.AddRangeAsync(newInvoiceList);
            _context.Invoices.Update(invoice);
            _context.CartItems.RemoveRange(cart.CartItems);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Invoice");
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> RemoveItem(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            string userId = await _userManager.GetUserIdAsync(user);
            if (userId == null)
            {
                return NotFound("Khong tim thay tai khoan");
            }
            // Get Cart
            Cart? cart;
            cart = await _context.Carts.FirstOrDefaultAsync(q => q.AppUserId == userId);
            if (cart == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItems.FirstOrDefaultAsync(q => q.Id == id);
            if (cart.Id != cartItem.CartId)
            {
                return NotFound("Không thể xóa hàng của người khác");
            }
            var productItem = await _context.ProductItems.FirstOrDefaultAsync(q => q.Id == cartItem.ProductItemId);
            if(productItem == null)
            {
                return NotFound();
            }
            try
            {
                productItem.Quantity += cartItem.Quantity;
                _context.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                throw;
            }
            return RedirectToAction("Index");
        }

        public async Task<string> GenerateOrderNumber()
        {
            // Length of the order number string
            int length = 8;

            // Characters allowed in the order number
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Create a Random object
            Random random = new Random();

            // Generate a random order number by combining random characters
            string orderNumber = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            // Combine with the current date to ensure uniqueness
            orderNumber = DateTime.Now.ToString("yyMMdd") + orderNumber;
            if(await _context.Invoices.AnyAsync(q => q.InvoiceCode == orderNumber))
            {
                orderNumber = await GenerateOrderNumber();
            }
            return orderNumber;
        }
    }
}
