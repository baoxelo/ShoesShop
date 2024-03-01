using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoesShop.Models;

namespace ShoesShop.Configuration.Entities
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Giày Boot",
                    Description = "Giày Boot da chất lượng cao sản xuất tại Việt Nam",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Slug = "giay-boot",
                    Status = "Hoạt động",
                },
                new Category
                {
                    Id = 2,
                    Name = "Giày thể thao",
                    Description = "Giày thể thao phù hợp với mọi hoạt động vui chơi (Nike, Adidas, Jordan, v.v)",
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    Slug = "giay-the-thao",
                    Status = "Hoạt động",
                }
                );
        }
    }
}
