using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoesShop.Models;
using System.Security.Claims;

namespace ShoesShop.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<ProductController> _logger;
        public ProductController(DatabaseContext databaseContext, ILogger<ProductController> logger)
        {
            _context = databaseContext;
            _logger = logger;

        }
        public async Task<IActionResult> Index( string slug)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Slug == slug);
            if (product == null)
            {
                return NotFound("Không tìm thấy sản phẩm");
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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return NotFound("Khong tim thay user");
            }
            _logger.LogInformation(userId);

            var cart = await _context.Carts.FirstOrDefaultAsync(q => q.AppUserId == userId);
            if (cart == null)
            {
                cart = new Cart()
                {
                    AppUserId = userId,
                    TotalPrice = 0,
                };
                await _context.Carts.AddAsync(cart);
            }
            _logger.LogInformation(userId);
            var slug = form["slug"];
            var quantity = form["quantity"];
            var sizeId = form["itemId"];
            int intSizeId;
            try
            {
                intSizeId = int.Parse(sizeId.ToString());
            }
            catch (FormatException)
            {
                return NotFound("Không tìm thấy item sản phẩm");
            }

            var product = await _context.Products.FirstOrDefaultAsync(q => q.Slug == slug);
            if(product == null)
            {
                return NotFound("Không tìm thấy sản phẩm");
            }
            _logger.LogInformation($"{sizeId} - {quantity}");
           
            return RedirectToAction("Index");
        }
    }
}
