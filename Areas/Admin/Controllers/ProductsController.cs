using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShoesShop.ExtensionServices;
using ShoesShop.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ShoesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "administrator")]
    public class ProductsController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ConvertSlug _convertSlug;
        private readonly FirebaseController _firebaseController;
        private readonly ILogger<ProductsController> _logger;
        public override void OnActionExecuting(ActionExecutingContext context) => ViewData["MenuBar"] = "Products";

        public ProductsController(DatabaseContext context, FirebaseController firebaseController, ILogger<ProductsController> logger, ConvertSlug convertSlug)
        {
            _firebaseController = firebaseController;
            _context = context;
            _logger = logger;
            _convertSlug = convertSlug;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products
                                .Include(p => p.Category)
                                .Include(p => p.Discount)
                                .OrderBy(p => p.Name)
                                .ToListAsync();

            foreach (var product in products)
            {
                product.Items = await _context.ProductItems
                    .Include(q => q.Size)
                    .Where(q => q.ProductId == product.Id)
                    .Where(q => q.Quantity != 0)
                    .ToListAsync();
            }

            return View(products);
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Discount)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "GenderType");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Name");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price,ImageFile,GenderId,CategoryId,DiscountId")] Product product)
        {
            foreach (var error in ViewData.ModelState.Values.SelectMany(modelState => modelState.Errors))
            {
                _logger.LogInformation(error.ErrorMessage);
            }
            if (ModelState.IsValid)
            {
                if(product.ImageFile == null)
                {
                    ModelState.AddModelError("Ảnh sản phẩm", "Ảnh sản phẩm là bắt buộc !");
                    return View(product);
                }
                var imageLink = await _firebaseController.UploadImagetoFirebase(product.ImageFile, product.Name);
                var discount = _context.Discounts.FirstOrDefault(d => d.Id == product.DiscountId);
                if(discount == null)
                {
                    return NotFound("Không tìm thấy mã giảm giá");
                }
                product.CurrentPrice = (product.Price * (100 - discount.Percent) / 100); 
                product.Slug = _convertSlug.ConvertString2Slug(product.Name);
                product.CreateDate = DateTime.Now;
                product.ModifyDate = DateTime.Now;
                product.Status = "Còn hàng";

                product.ImageLink = imageLink;
                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                //Create product items with all size and quantity equal 0 and five product images
                foreach (var sizeId in _context.Sizes.Select(q => q.Id))
                {
                    var productItem = new ProductItem()
                    {
                        ProductId = product.Id,
                        SizeId = sizeId,
                        Quantity = 0,
                    };
                    _context.ProductItems.Add(productItem);
                }
                for(var i = 0; i < 6; i++)
                {
                    var productImage = new ProductImage()
                    {
                        ProductId = product.Id,
                        ImageLink = null,
                    };
                    _context.ProductImages.Add(productImage);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("CreateProductItem", new { id = product.Id });
                
            }
            ViewData["CategoryId"] = new SelectList(_context.Genders, "Id", "GenderType", product.GenderId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Name", product.DiscountId);
            return View(product);
        }

        public IActionResult CreateProductItem(int id)
        {
            var productItem =  _context.ProductItems.Include(q => q.Size).Where(q => q.ProductId == id).ToList();
            
            return View(productItem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProductItem(List<ProductItem> listProductItem)
        {
            var product = _context.Products.FirstOrDefault(q => q.Id == listProductItem[0].ProductId);
            if(product == null)
            {
                return NotFound("Không tìm thấy sản phẩm được tạo");
            }
            try
            {
                _context.ProductItems.UpdateRange(listProductItem);
                await _context.SaveChangesAsync();
                TempData["StatusMessage"] = "Thêm size sản phẩm thành công";
                return RedirectToAction("CreateProductImage", new { id = product.Id });
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message, ex);
                TempData["StatusMessage"] = $"Error: Có lỗi xảy ra : {ex.Message}";
                return View(listProductItem);
            }
        }

        public IActionResult CreateProductImage(int id)
        {
            var productImages = _context.ProductImages.Where(q => q.ProductId == id).ToList();

            return View(productImages);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProductImage(List<ProductImage> listProductImages)
        {
            try
            {
                var product = _context.Products.FirstOrDefault(q => q.Id == listProductImages[1].ProductId);
                if(product == null)
                {
                    return NotFound("Không tìm thấy sản phẩm");
                }
                for(var i = 0; i< listProductImages.Count; i++)
                {
                    var file = listProductImages[i].ImageFile;
                    if (file != null)
                    {
                        var label = (string)(product.Name + listProductImages[i].Id.ToString());
                        var link = await _firebaseController.UploadImagetoFirebase(file, label);
                        listProductImages[i].ImageLink = link;
                    }
                    else
                    {

                        listProductImages[i].ImageLink = "";
                    }
                }
                _context.ProductImages.UpdateRange(listProductImages);
                await _context.SaveChangesAsync();
                TempData["StatusMessage"] = "Thêm sản phẩm thành công";
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message, ex);
                TempData["StatusMessage"] = $"Error: Có lỗi xảy ra : {ex.Message}";
                return View(listProductImages);
            }
            return RedirectToAction("Index");
        }
        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Products
                                .Include(p => p.Gender)
                                .Include(p => p.Category)
                                .Include(p => p.Discount)
                                .FirstOrDefaultAsync(p => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }

            product.Items = await _context.ProductItems
                    .Include(q => q.Size)
                    .Where(q => q.ProductId == product.Id)
                    .ToListAsync();
            product.Images = await _context.ProductImages
                    .Where(q => q.ProductId == product.Id)
                    .ToListAsync();

            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "GenderType", product.GenderId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Name", product.DiscountId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,ImageFile,GenderId,CategoryId,DiscountId,Items, Images")] Product updateProduct)
        {
            if (id != updateProduct.Id)
            {
                return NotFound();
            }
            var product = await _context.Products
                                .Include(p => p.Category)
                                .Include(p => p.Discount)
                                .FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if(updateProduct.ImageFile != null)
                    {
                        var imageLink = await _firebaseController.UploadImagetoFirebase(updateProduct.ImageFile, updateProduct.Name);
                        product.ImageLink = imageLink;
                    }
                    // Update product 
                    product.Name = updateProduct.Name;
                    product.Description = updateProduct.Description;
                    product.Price = updateProduct.Price;
                    product.CategoryId = updateProduct.CategoryId;
                    product.DiscountId = updateProduct.DiscountId;
                    product.Slug = _convertSlug.ConvertString2Slug(updateProduct.Name);
                    if(product.Discount != null)
                    {
                        product.CurrentPrice = (product.Price * (100 - product.Discount.Percent) / 100);   
                    }
                    product.ModifyDate = DateTime.Now;
                    var totalQuantity = 0;

                    //Update product images
                    if(updateProduct.Images != null)
                    {
                        for (var i = 0; i < updateProduct.Images.Count(); i++)
                        {
                            var file = updateProduct.Images[i].ImageFile;
                            if (file != null)
                            {
                                var label = (string)(product.Name + updateProduct.Images[i].Id.ToString());
                                var link = await _firebaseController.UploadImagetoFirebase(file, label);
                                updateProduct.Images[i].ImageLink = link;
                            }
                        }
                        _context.ProductImages.UpdateRange(updateProduct.Images);
                    }

                    // Update product items
                    if(updateProduct.Items != null)
                    {
                        foreach (var item in updateProduct.Items)
                        {
                            totalQuantity += item.Quantity;
                        }

                        if (totalQuantity == 0)
                        {
                            product.Status = "Hết hàng";
                        }
                        _context.ProductItems.UpdateRange(updateProduct.Items);
                    }

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            product.Items = updateProduct.Items;
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "GenderType", product.GenderId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Name", product.DiscountId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Discount)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            product.Items = await _context.ProductItems
                    .Include(q => q.Size)
                    .Where(q => q.ProductId == product.Id)
                    .ToListAsync();
            product.Images = await _context.ProductImages.Where(q => q.ProductId == id).ToListAsync();
            
            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound("Không tìm thấy sản phẩm");
            }
            // Remove product items
            var items = _context.ProductItems.Where(p => p.ProductId == id);
            _context.ProductItems.RemoveRange(items);

            // Remove product avatar 
            await _firebaseController.DeleteImagetoFirebase(product.Name);

            // Remove images on Firebase
            var images = _context.ProductImages.Where(q => q.ProductId == id);
            foreach (var image in images)
            {
                var label = (string)(product.Name + image.Id.ToString());
                await _firebaseController.DeleteImagetoFirebase(label);
            }
            // Remove product images
            _context.ProductImages.RemoveRange(images);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
