using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ShoesShop.ExtensionServices;
using ShoesShop.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace ShoesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _context;
        private readonly UserManager<AppUser> _userManager;
        

        public HomeController(ILogger<HomeController> logger, DatabaseContext context, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            
        }

        public async Task<IActionResult> Index()
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

            var categories = await _context.Categories.ToListAsync();
            foreach (var category in categories)
            {
                category.Products = await _context.Products.Where(q => q.CategoryId == category.Id).ToListAsync();
            }

            // Get Sliders
            var slider = await _context.Slider.ToListAsync();
            TempData["Sliders"] = slider;

            

            return View(categories);
        }

        [ActionName("chinh-sach")]
        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
