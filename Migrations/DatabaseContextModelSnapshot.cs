﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoesShop.Models;

#nullable disable

namespace ShoesShop.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "39f6c631-fb13-499c-9079-7cef9f9dcc4b",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "262234fe-63dd-4f6b-9f2b-12ef2b120717",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("ShoesShop.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ShoesShop.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AppUserId")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("ShoesShop.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductItemId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("ShoesShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Slug")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Status")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1442),
                            Description = "Giày Boot da chất lượng cao sản xuất tại Việt Nam",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1467),
                            Name = "Giày Boot",
                            Slug = "giay-boot",
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1475),
                            Description = "Giày thể thao phù hợp với mọi hoạt động vui chơi (Nike, Adidas, Jordan, v.v)",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1476),
                            Name = "Giày thể thao",
                            Slug = "giay-the-thao",
                            Status = "Hoạt động"
                        });
                });

            modelBuilder.Entity("ShoesShop.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Percent")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Discount");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1967),
                            Description = "Không giảm",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1972),
                            Name = "00%",
                            Percent = 0,
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1977),
                            Description = "Không giảm",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1978),
                            Name = "10%",
                            Percent = 10,
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1981),
                            Description = "Giảm 20%",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1982),
                            Name = "20%",
                            Percent = 20,
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1987),
                            Description = "Giảm 30%",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1988),
                            Name = "30%",
                            Percent = 30,
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1990),
                            Description = "Giảm 40%",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1991),
                            Name = "40%",
                            Percent = 40,
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1993),
                            Description = "Giảm 50%",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1994),
                            Name = "50%",
                            Percent = 50,
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1996),
                            Description = "Giảm 60%",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(1997),
                            Name = "60%",
                            Percent = 60,
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(2000),
                            Description = "Giảm 70%",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(2001),
                            Name = "70%",
                            Percent = 70,
                            Status = "Hoạt động"
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(2003),
                            Description = "Giảm 80%",
                            ModifyDate = new DateTime(2024, 4, 16, 14, 0, 44, 964, DateTimeKind.Local).AddTicks(2004),
                            Name = "80%",
                            Percent = 80,
                            Status = "Hoạt động"
                        });
                });

            modelBuilder.Entity("ShoesShop.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GenderType")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenderType = "Unisex"
                        },
                        new
                        {
                            Id = 2,
                            GenderType = "Nam"
                        },
                        new
                        {
                            Id = 3,
                            GenderType = "Nữ"
                        },
                        new
                        {
                            Id = 4,
                            GenderType = "Trẻ em"
                        });
                });

            modelBuilder.Entity("ShoesShop.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("AppUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateOrdered")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvoiceCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("TotalPrice")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("StatusId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("ShoesShop.Models.InvoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductItemId");

                    b.ToTable("InvoiceItem");
                });

            modelBuilder.Entity("ShoesShop.Models.InvoiceStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("InvoiceStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Chúng tôi sẽ sớm liên hệ với bạn",
                            Status = "Đang chờ xác nhận"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Đơn hàng đang được vận chuyển đến bạn",
                            Status = "Đang giao"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Đơn hàng đã được hoàn tất",
                            Status = "Hoàn tất"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Đơn hàng đã bị hủy",
                            Status = "Đơn hàng bị hủy"
                        });
                });

            modelBuilder.Entity("ShoesShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<double?>("CurrentPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("DiscountId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Slug")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Sold")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("GenderId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ShoesShop.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("ShoesShop.Models.ProductItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SizeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductItems");
                });

            modelBuilder.Entity("ShoesShop.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "US = 4.5, UK = 2.5, 21.3 cm",
                            Name = "35"
                        },
                        new
                        {
                            Id = 2,
                            Description = "US = 5.5, UK = 3.5, 22.2 cm",
                            Name = "36"
                        },
                        new
                        {
                            Id = 3,
                            Description = "US = 4, UK = 4.5, 23 cm",
                            Name = "37"
                        },
                        new
                        {
                            Id = 4,
                            Description = "US = 5, UK = 5.5, 23.8 cm",
                            Name = "38"
                        },
                        new
                        {
                            Id = 5,
                            Description = "US = 6, UK = 6.5, 24.6 cm",
                            Name = "39"
                        },
                        new
                        {
                            Id = 6,
                            Description = "US = 7, UK = 7.5, 25.4 cm",
                            Name = "40"
                        },
                        new
                        {
                            Id = 7,
                            Description = "US = 8, UK = 8.5, 26.2 cm",
                            Name = "41"
                        },
                        new
                        {
                            Id = 8,
                            Description = "US = 8, UK = 8.5, 26.2 cm",
                            Name = "42"
                        },
                        new
                        {
                            Id = 9,
                            Description = "US = 8, UK = 8.5, 26.2 cm",
                            Name = "43"
                        },
                        new
                        {
                            Id = 10,
                            Description = "US = 8, UK = 8.5, 26.2 cm",
                            Name = "44"
                        });
                });

            modelBuilder.Entity("ShoesShop.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Slider");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ShoesShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ShoesShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoesShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ShoesShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShoesShop.Models.Cart", b =>
                {
                    b.HasOne("ShoesShop.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("ShoesShop.Models.CartItem", b =>
                {
                    b.HasOne("ShoesShop.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoesShop.Models.ProductItem", "ProductItem")
                        .WithMany()
                        .HasForeignKey("ProductItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("ShoesShop.Models.Invoice", b =>
                {
                    b.HasOne("ShoesShop.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("ShoesShop.Models.InvoiceStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ShoesShop.Models.InvoiceItem", b =>
                {
                    b.HasOne("ShoesShop.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoesShop.Models.ProductItem", "ProductItem")
                        .WithMany()
                        .HasForeignKey("ProductItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("ShoesShop.Models.Product", b =>
                {
                    b.HasOne("ShoesShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoesShop.Models.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoesShop.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Discount");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("ShoesShop.Models.ProductImage", b =>
                {
                    b.HasOne("ShoesShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShoesShop.Models.ProductItem", b =>
                {
                    b.HasOne("ShoesShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoesShop.Models.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Size");
                });
#pragma warning restore 612, 618
        }
    }
}
