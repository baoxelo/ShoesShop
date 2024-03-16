using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoesShop.Models;

namespace ShoesShop.Controllers
{
    [Authorize]
    public class InvoiceController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<InvoiceController> _logger;
        private readonly UserManager<AppUser> _userManager;
        public InvoiceController(DatabaseContext context, ILogger<InvoiceController> logger, UserManager<AppUser> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index()
        {
            // GET USER
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

            // GET CART
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

            // GET INVOICE
            List<Invoice> invoices = await _context.Invoices.Where(q => q.AppUserId == userId).OrderByDescending(q => q.DateOrdered).Include(q => q.Status).ToListAsync();
            foreach (var item in invoices)
            {
                item.InvoiceItems = await _context.InvoiceItems
                                        .Where(q => q.InvoiceId == item.Id)
                                        .Include(q => q.ProductItem)
                                        .ThenInclude(q => q.Product)
                                        .ThenInclude(q => q.Discount)
                                        .Include(q => q.ProductItem)
                                        .ThenInclude( q => q.Size)
                                        .ToListAsync();
            }
            return View(invoices);
        }
    }
}
