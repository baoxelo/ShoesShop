using Firebase.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using ShoesShop.Configuration.Entities;
using System.Reflection.Emit;

namespace ShoesShop.Models
{
    public class DatabaseContext : IdentityDbContext<AppUser> 
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string dbPath = Path.Combine(_webHostEnvironment.ContentRootPath, "Data/Database/database.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName != null && tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            };


            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new DiscountConfiguration());
            builder.ApplyConfiguration(new GenderConfiguration());
            builder.ApplyConfiguration(new SizeConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new InvoiceStatusConfiguration());
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options, IWebHostEnvironment webHostEnvironment) : base(options) 
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
    }
}
