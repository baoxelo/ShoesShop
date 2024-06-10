using ShoesShop.Models;

namespace ShoesShop.Areas.Admin.Models
{
    public class Dashboard
    {
        public double TotalIncome { get; set; }
        public double TotalInvoice { get; set; }
        public double TodayInvoice { get; set; }
        public double TodayIncome { get; set; }
        public string MonthPercentageIncrease { get; set; }
        public string YearPercentageIncrease { get; set; }
        public double TotalUser { get; set; }
        public string MonthRevenue { get; set; }
        public string YearRevenue { get; set; }
        public string LastYearRevenue { get; set; }
        public int GrowthPercent {  get; set; }
        public List<DashboardCategory> Categories { get; set; }
        public List<MonthStatic> MonthStatics { get; set; }
        public List<TopUser> TopUsers { get; set; }
        public List<RecentCart> RecentCarts { get; set;}

    }
    public class DashboardCategory 
    {
        public Category Category { get; set; }
        public int Quantity { get; set; }
    }
    public class MonthStatic
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public double Sale { get; set;}
    }
    public class TopUser
    {
        public AppUser User { get; set; }
        public double Expenditure { get; set; }
    }

    public class RecentCart
    {
        public AppUser User { get; set; }
        public CartItem CartItem { get; set; }
    }
}
