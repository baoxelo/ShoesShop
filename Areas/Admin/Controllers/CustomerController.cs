using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoesShop.Models;

namespace ShoesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "administrator")]

    public class CustomerController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public CustomerController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.OrderByDescending(q => q.Id).ToListAsync();
            return View(users);
        }

        public async Task<IActionResult> Detail (string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }
        public async Task<IActionResult> Ban(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }

        // POST: Admin/Customer/Ban/5
        [HttpPost, ActionName("Ban")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BanConfirmed(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            await _userManager.SetLockoutEndDateAsync(user , DateTime.MaxValue);
            return RedirectToAction(nameof(Index));
        }
    }
}
