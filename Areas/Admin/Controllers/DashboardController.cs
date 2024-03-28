using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ShoesShop.Areas.Admin.Models;
using ShoesShop.Models;

namespace ShoesShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class DashboardController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<AppUser> _userManager;
        public override void OnActionExecuting(ActionExecutingContext context) => ViewData["MenuBar"] = "Dashboard";

        public DashboardController(DatabaseContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var dashboard = new Dashboard()
            {
                Categories = new List<DashboardCategory>(),
                MonthStatics = new List<MonthStatic> ()
            };

            dashboard.TodayInvoice = await _context.Invoices
                                        .Where(q => q.DateOrdered == DateTime.Today.Date)
                                        .CountAsync();

            dashboard.TotalInvoice = await _context.Invoices
                                        .Include(q => q.Status)
                                        .Where(q => q.Status.Status == "Hoàn tất")
                                        .CountAsync();

            dashboard.TotalIncome = await _context.Invoices
                                        .Include(q => q.Status)
                                        .Where(q => q.Status.Status == "Hoàn tất")
                                        .SumAsync(q => q.TotalPrice) ?? 0;

            dashboard.TotalUser = await _userManager.Users.CountAsync();

            List<Category> categories = await _context.Categories.ToListAsync();

            var invoiceItems = await _context.InvoiceItems
                                        .Include(q => q.ProductItem)
                                        .ThenInclude(q => q.Product)
                                        .Include(q => q.Invoice)
                                        .ThenInclude(q => q.Status)
                                        .Where(q => q.Invoice.Status.Status == "Hoàn tất")
                                        .ToListAsync();

            foreach (var category in categories)
            {
                var items = invoiceItems.Where(q => q.ProductItem.Product.CategoryId == category.Id);

                DashboardCategory dashboardCategory = new DashboardCategory()
                {
                    Category = category,
                    Quantity = items.Sum(q => q.Quantity),
                };
                dashboard.Categories.Add(dashboardCategory);
            }


            var months = await _context.Invoices.Select(q => q.DateOrdered.Month)
                                        .Distinct()
                                        .ToListAsync();

            foreach(var month in months)
            {

                MonthStatic monthStatic = new MonthStatic()
                {
                    Name = month.ToString(),
                    TotalIncome = await _context.Invoices.Where(q => q.DateOrdered.Month == month).SumAsync(q => q.TotalPrice) ?? 0,
                };
                dashboard.MonthStatics.Add(monthStatic);
            }

            return View(dashboard);
        }
        public IActionResult Logistic()
        {
            return View();
        }
    }
}
