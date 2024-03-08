using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoesShop.ExtensionServices;
using ShoesShop.Models;
using System.Security.Claims;

namespace ShoesShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<ProductController> _logger;
        private readonly UserManager<AppUser> _userManager;
        public ProductController(DatabaseContext databaseContext, ILogger<ProductController> logger, UserManager<AppUser> userManager)
        {
            _context = databaseContext;
            _logger = logger;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index( string slug)
        {
            // Load card 
            if (_context != null && _userManager != null && User != null && User.Identity.IsAuthenticated)
            {
                string userId;
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    userId = await _userManager.GetUserIdAsync(user);
                    if (userId != null)
                    {
                        // Get Cart
                        var cart = await _context.Carts.FirstOrDefaultAsync(q => q.AppUserId == userId);
                        if (cart != null)
                        {
                            cart.CartItems = await _context.CartItems.Where(q => q.CartId == cart.Id)
                                .Include(q => q.ProductItem)
                                    .ThenInclude(p => p.Size)
                                    .Include(q => q.ProductItem)
                                    .ThenInclude(p => p.Product)
                                    .ToListAsync();
                        }
                        TempData["Cart"] = cart;
                    }
                }
            }
            var product = await _context.Products.Include(q => q.Category).FirstOrDefaultAsync(x => x.Slug == slug);
            if (product == null)
            {
                return NotFound("Không tìm thấy sản phẩm");
            }
            if(product.Category != null)
            {
                product.Category.Products = await _context.Products.Where(q => q.CategoryId == product.CategoryId && q.Id != product.Id).ToListAsync();
            }
            product.Images = await _context.ProductImages.Where(q => q.ProductId == product.Id).ToListAsync();
            product.Items = await _context.ProductItems.Include(q => q.Size).Where(q => q.ProductId == product.Id).ToListAsync();
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Name");
            return View( product);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BuyProduct (IFormCollection form)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier).ToString();
            if (userId == null)
            {
                return NotFound("Khong tim thay user");
            }

            var cart = await _context.Carts.FirstOrDefaultAsync(q => q.AppUserId == userId);
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
                if(cart == null)
                {
                    return NotFound("Có lỗi xảy ra");
                }
            }
            _logger.LogInformation(userId);
            var slug = Convert.ToString(form["slug"]);
            var quantity = Convert.ToInt32(form["quantity"]);
            var sizeId = Convert.ToInt32(form["itemId"]);

            var product = await _context.Products.FirstOrDefaultAsync(q => q.Slug == slug);
            if(product == null)
            {
                return NotFound("Không tìm thấy sản phẩm");
            }
            var productItem = await _context.ProductItems.FirstOrDefaultAsync(q => q.ProductId == product.Id && q.SizeId == sizeId);
            if (productItem == null || productItem.Quantity <= 0 || quantity > productItem.Quantity)
            {
                return NotFound("Sản phẩm còn lại không đủ");
            }
            try
            {
                var cartItem = await _context.CartItems.Where(q => q.ProductItemId == productItem.Id && q.CartId == cart.Id).FirstOrDefaultAsync();
                if(cartItem != null)
                {
                    cartItem.Quantity += quantity;
                }
                else
                {
                    cartItem = new CartItem()
                    {
                        ProductItemId = productItem.Id,
                        Quantity = quantity,
                        CartId = cart.Id,
                    };
                    await _context.CartItems.AddAsync(cartItem);
                }
                productItem.Quantity -= quantity;
                cart.TotalPrice = quantity * product.CurrentPrice ?? 0;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { slug });

            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.ToString());

                return NotFound("Có lỗi xảy ra");
            }
        }
    }
}
