using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoesShop.ExtensionServices;
using ShoesShop.Models;

namespace ShoesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class CategoriesController : Controller
    {
        private readonly ConvertSlug _convertSlug;
        private readonly DatabaseContext _context;
        public override void OnActionExecuting(ActionExecutingContext context) => ViewData["MenuBar"] = "Categories";

        public CategoriesController(DatabaseContext context, ConvertSlug convertSlug)
        {
            _context = context;
            _convertSlug = convertSlug;
        }

        // GET: Admin/Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Admin/Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admin/Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Category category)
        {
            if (!ModelState.IsValid || category == null)
            {
                return View(category);
            }
            if (_context.Categories.Any(q => q.Name == category.Name))
            {
                TempData["StatusMessage"] = $"Error: Danh mục này đã tồn tại {category.Name}";
                return View(category);
            }

            category.Slug = _convertSlug.ConvertString2Slug(category.Name);
            category.CreateDate = DateTime.Now;
            category.ModifyDate = DateTime.Now;
            category.Status = "Còn hàng";
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            TempData["StatusMessage"] = $"Bạn đã tạo mới danh mục {category.Name}";
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Status")] Category updateCategory)
        {
            if (id != updateCategory.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var category = await _context.Categories.FindAsync(id);
                    if (category == null) return NotFound();

                    if (_context.Categories.Any(q => q.Name == updateCategory.Name && q.Name != category.Name))
                    {
                        TempData["StatusMessage"] = $"Error: Danh mục này đã tồn tại {updateCategory.Name}";
                        return View(updateCategory);
                    }
                    category.ModifyDate = DateTime.Now;
                    category.Name = updateCategory.Name;
                    category.Slug = _convertSlug.ConvertString2Slug(updateCategory.Name);
                    category.Description = updateCategory.Description;
                    category.Status = updateCategory.Status;
                    await _context.SaveChangesAsync();

                    TempData["StatusMessage"] = $"Bạn đã cập nhật danh mục {updateCategory.Name}";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(updateCategory.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            return View(updateCategory);
        }

        // GET: Admin/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }
            TempData["StatusMessage"] = $"Bạn đã xóa danh mục {category.Name}";
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
