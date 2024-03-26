using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ShoesShop.Areas.Admin.Models;
using ShoesShop.Models;

namespace ShoesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "administrator")]
    public class DashboardController : Controller
    {
        private readonly DatabaseContext _context;
        public override void OnActionExecuting(ActionExecutingContext context) => ViewData["MenuBar"] = "Dashboard";

        public DashboardController(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dashboard = new Dashboard();
            dashboard.TotalInvoice = _context.Invoices.Where(q => q.DateOrdered <= DateTime.Today && q.DateOrdered > DateTime.Today.AddDays(-1)).Count();
            
            return View();
        }
        public IActionResult Logistic()
        {
            return View();
        }
    }
}
