using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoesShop.Models;

namespace ShoesShop.Configuration.Entities
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasData(
                new Discount
                {
                    Id = 1,
                    Name = "00%",
                    Description = "Không giảm",
                    Percent = 0,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Status = "Hoạt động"

                },
                new Discount
                {
                    Id = 2,
                    Name = "20%",
                    Description = "Giảm 20%",
                    Percent = 20,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Status = "Hoạt động"
                },
                new Discount
                {
                    Id = 3,
                    Name = "30%",
                    Description = "Giảm 30%",
                    Percent = 30,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Status = "Hoạt động"
                },
                new Discount
                {
                    Id = 4,
                    Name = "40%",
                    Description = "Giảm 40%",
                    Percent = 40,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Status = "Hoạt động"
                },
                new Discount
                {
                    Id = 5,
                    Name = "50%",
                    Description = "Giảm 50%",
                    Percent = 50,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Status = "Hoạt động"
                },
                new Discount
                {
                    Id = 6,
                    Name = "60%",
                    Description = "Giảm 60%",
                    Percent = 60,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Status = "Hoạt động"
                },
                new Discount
                {
                    Id = 7,
                    Name = "70%",
                    Description = "Giảm 70%",
                    Percent = 70,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Status = "Hoạt động"
                },
                new Discount
                {
                    Id = 8,
                    Name = "80%",
                    Description = "Giảm 80%",
                    Percent = 80,
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Status = "Hoạt động"
                }
                );
        }
    }
}
