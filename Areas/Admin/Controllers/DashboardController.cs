using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShoesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "administrator")]
    public class DashboardController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context) => ViewData["MenuBar"] = "Dashboard";

        public DashboardController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Logistic()
        {
            return View();
        }
    }
}
