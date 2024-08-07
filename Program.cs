﻿using Microsoft.EntityFrameworkCore;
using ShoesShop.Models;
using ShoesShop.ExtensionServices;
using Microsoft.AspNetCore.Identity.UI.Services;
using ShoesShop.Services;
using ShoesShop;
using Microsoft.AspNetCore.Identity;
using ShoesShop.Configuration;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<FirebaseController>();
builder.Services.AddTransient<ConvertSlug>();
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
builder.Services.ConfigureIdentity();
builder.Services.AddAuthorization();
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IEmailSender, SendMailService>();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.LogoutPath = "/Identity/Account/Logout";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
});
builder.Services.AddAuthentication().AddGoogle(googleOptions => {
    // Đọc thông tin Authentication:Google từ appsettings.json
    IConfigurationSection googleAuthNSection = builder.Configuration.GetSection("Authentication:Google");

    // Thiết lập ClientID và ClientSecret để truy cập API google
    googleOptions.ClientId = googleAuthNSection["ClientId"];
    googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
    // Cấu hình Url callback lại từ Google (không thiết lập thì mặc định là /signin-google)
    googleOptions.CallbackPath = "/Login-Google";
    googleOptions.ClaimActions.MapJsonKey("image", "picture");
});
builder.Services.Configure<SecurityStampValidatorOptions>(options =>
{
    // Trên 30 giây truy cập lại sẽ nạp lại thông tin User (Role)
    // SecurityStamp trong bảng User đổi -> nạp lại thông tinn Security
    options.ValidationInterval = TimeSpan.FromSeconds(30);
});
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
    name: "collection",
    pattern: "/trang-chu/danh-muc/",
    defaults: new { controller = "Home", action = "Collection" }
    );

app.MapControllerRoute(
    name: "home",
    pattern: "/trang-chu/{action=Index}/{slug?}",
    defaults: new {controller = "Home", action = "Index" }
    );


app.MapControllerRoute(
    name: "cart",
    pattern: "/gio-hang/{action}/{id?}",
    defaults: new { controller = "Cart", action = "Index" }
    );

app.MapControllerRoute(
    name: "invoice",
    pattern: "/don-hang/{action}/{id?}",
    defaults: new { controller = "Invoice", action = "Index" }
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
