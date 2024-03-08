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
                                    .ToListAsync();
            TempData["Cart"] = cart;
            return View(cart);
        }
    }
}
