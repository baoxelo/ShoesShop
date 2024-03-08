using Microsoft.EntityFrameworkCore;
using ShoesShop.Models;
using ShoesShop.ExtensionServices;
using Microsoft.AspNetCore.Identity.UI.Services;
using ShoesShop.Services;
using ShoesShop;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<FirebaseController>();
builder.Services.AddTransient<ConvertSlug>();
builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<DatabaseContext>();
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IEmailSender, SendMailService>();
builder.Services.AddAuthentication().AddGoogle(googleOptions => {
    // Đọc thông tin Authentication:Google từ appsettings.json
    IConfigurationSection googleAuthNSection = builder.Configuration.GetSection("Authentication:Google");

    // Thiết lập ClientID và ClientSecret để truy cập API google
    googleOptions.ClientId = googleAuthNSection["ClientId"];
    googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
    // Cấu hình Url callback lại từ Google (không thiết lập thì mặc định là /signin-google)
    googleOptions.CallbackPath = "/Login-Google";
});
builder.Services.ConfigureIdentity();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "home",
    pattern: "/trang-chu/{action}/{id?}",
    defaults: new {controller = "Home", action = "Index" }
    );


app.MapControllerRoute(
    name: "product",
    pattern: "/san-pham/{slug}",
    defaults: new { controller = "Product", action = "Index" }
    );

app.MapControllerRoute(
    name: "default",
    pattern: "/{controller=Home}/{action=Index}/{id?}"
    );

app.MapRazorPages();

app.Run();
