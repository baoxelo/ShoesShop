using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoesShop.Models;

namespace ShoesShop.Configuration.Entities
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(
                new Gender
                {
                    Id = 1,
                    GenderType = "Unisex",
                },
                new Gender
                {
                    Id = 2,
                    GenderType = "Nam",
                },
                new Gender
                {
                    Id = 3,
                    GenderType = "Nữ",
                },
                new Gender
                {
                    Id = 4,
                    GenderType = "Trẻ em",
                }
                );
        }
    }
}
