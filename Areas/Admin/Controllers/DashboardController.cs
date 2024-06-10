using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
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
        private readonly ILogger<DashboardController> _logger;
        public override void OnActionExecuting(ActionExecutingContext context) => ViewData["MenuBar"] = "Dashboard";

        public DashboardController(DatabaseContext context, UserManager<AppUser> userManager, ILogger<DashboardController> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var dashboard = new Dashboard()
            {
                Categories = new List<DashboardCategory>(),
                MonthStatics = new List<MonthStatic> ()
            };

            // DAILY STATISTIC -------------------------------------------------------------------
            dashboard.TodayInvoice = await _context.Invoices
                                        .Where(q => q.DateOrdered.Date == DateTime.Today.Date)
                                        .CountAsync();

            dashboard.TotalInvoice = await _context.Invoices
                                        .Include(q => q.Status)
                                        .Where(q => q.Status.Status == "Hoàn tất")
                                        .CountAsync();

            dashboard.TotalIncome = await _context.Invoices
                                        .Include(q => q.Status)
                                        .Where(q => q.Status.Status == "Hoàn tất")
                                        .SumAsync(q => q.TotalPrice) ?? 0;



            // CATEGORIES STATISTIC -------------------------------------------------------------------

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
                category.Products = _context.Products.Where(q => q.CategoryId == category.Id).Take(2).ToList();
                DashboardCategory dashboardCategory = new DashboardCategory()
                {
                    Category = category,
                    Quantity = items.Sum(q => q.Quantity),
                };
                dashboard.Categories.Add(dashboardCategory);
            }

            // CHART STATISTIC -------------------------------------------------------------------

            var invoices = await _context.Invoices.ToListAsync();
            int[] years = [DateTime.Now.Year, DateTime.Now.AddYears(-1).Year];
            foreach(var year in years)
            {
                for (int i = 1; i <= 12; i++) 
                {
                    MonthStatic monthStatic = new MonthStatic()
                    {
                        Month = i,
                        Year = year,
                        Sale = await _context.Invoices
                                        .Where(q => q.DateOrdered.Month == i && q.DateOrdered.Year == year && q.StatusId == 3)
                                        .SumAsync(q => q.TotalPrice) ?? 0,
                    };
                    dashboard.MonthStatics.Add(monthStatic);

                }
            }

            var monthRevenue = dashboard.MonthStatics
                                        .FirstOrDefault(q => q.Month == DateTime.Today.Month && q.Year == DateTime.Today.Year)?
                                        .Sale ?? 0;

            var yearRevenue = await _context.Invoices
                                .Where(q => q.DateOrdered.Year == DateTime.Now.Year && q.StatusId == 3)
                                .SumAsync(q => q.TotalPrice) ?? 0;


            dashboard.TodayIncome = await _context.Invoices
                                    .Where(q => q.DateOrdered.Date == DateTime.Today.Date)
                                    .SumAsync(q => q.TotalPrice) ?? 0;
            dashboard.MonthPercentageIncrease = dashboard.TodayIncome != 0 ? ((dashboard.TodayIncome / monthRevenue) * 100).ToString("0.#") : "0";

            dashboard.YearPercentageIncrease = dashboard.TodayIncome != 0 ? ((dashboard.TodayIncome / yearRevenue) * 100).ToString("0.#") : "0";

            dashboard.MonthRevenue = (monthRevenue / 1_000_000).ToString("0.##") + " M";

            dashboard.YearRevenue = (yearRevenue / 1_000_000).ToString("0.##") + " M";

            double lastYearRevenue = await _context.Invoices
                                            .Where(q => q.DateOrdered.Year == DateTime.Today.AddYears(-1).Year)
                                            .SumAsync(q => q.TotalPrice) ?? 0;
            dashboard.LastYearRevenue = (lastYearRevenue / 1_000_000).ToString("0.##") + " M";

            dashboard.GrowthPercent = (int)((yearRevenue / lastYearRevenue) * 100);

            // CART ANALYTICS STATISTIC -------------------------------------------------------------------

            var cart = _context.CartItems
                            .OrderByDescending(q => q.Id)
                            .Take(6)
                            .Include(q => q.ProductItem)
                            .ThenInclude(q => q.Product)
                            .Include(q => q.Cart)
                            .ThenInclude(q => q.AppUser);
            dashboard.RecentCarts = new List<RecentCart>();
            foreach(var item in cart)
            {
                var user = await _userManager.FindByIdAsync(item.Cart.AppUserId);
                if(user != null)
                {
                    var recentCart = new RecentCart()
                    {
                        User = user,
                        CartItem = item,
                    };
                    dashboard.RecentCarts.Add(recentCart);
                }
                
            }





            // USER EXPENDITURE STATISTIC -------------------------------------------------------------------
            dashboard.TotalUser = await _userManager.Users.CountAsync();
            var allUser = await _userManager.Users.ToListAsync();
            var topUsers = new List<TopUser>();
            foreach (var user in allUser)
            {
                var topUser = new TopUser 
                { 
                    User = user,
                    Expenditure = await _context.Invoices.Where(q => q.AppUserId == user.Id).SumAsync(q => q.TotalPrice) ?? 0,
                };
                topUsers.Add(topUser);
            }
            dashboard.TopUsers = topUsers.OrderByDescending(q => q.Expenditure).ToList();

            return View(dashboard);
        }
        public IActionResult Logistic()
        {
            return View();
        }
    }
}
