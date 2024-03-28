﻿using ShoesShop.Models;

namespace ShoesShop.Areas.Admin.Models
{
    public class Dashboard
    {
        public double TotalIncome { get; set; }
        public double TotalInvoice { get; set; }
        public double TodayInvoice { get; set; }
        public double TotalUser { get; set; }
        public List<DashboardCategory> Categories { get; set; }
        public List<MonthStatic> MonthStatics { get; set; }

    }
    public class DashboardCategory 
    {
        public Category Category { get; set; }
        public int Quantity { get; set; }
    }
    public class MonthStatic
    {
        public string Name { get; set; }
        public double TotalIncome { get; set;}
    }
}
