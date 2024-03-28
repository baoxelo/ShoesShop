using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShoesShop.Areas.Admin.Models;
using ShoesShop.Models;

namespace ShoesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class UserRoleController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public override void OnActionExecuting(ActionExecutingContext context) => ViewData["MenuBar"] = "ManageUser";
        public UserRoleController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = _userManager.Users.ToList();
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.RoleNames = string.Join(", ", roles);
            }
            return View(users);
        }
        public async Task<IActionResult> Detail(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var roles = await _roleManager.Roles.ToListAsync();
            ViewData["RoleId"] = new SelectList(roles, "Id", "Name");
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetRole(string roleId, string userId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            List<string> roles = new List<string> { role.Name };
            var user = await _userManager.FindByIdAsync(userId);
            if (role == null || user == null)
            {
                return NotFound("Không tìm thấy user hoặc role");
            }
            await _userManager.AddToRolesAsync(user, roles);
            TempData["StatusMessage"] = $"Cập nhật role thành công cho user {user.UserName}";
            return RedirectToAction("Index");
        }
    }
}
