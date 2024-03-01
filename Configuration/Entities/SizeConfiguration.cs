using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoesShop.Models;

namespace ShoesShop.Configuration.Entities
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size
                {
                    Id = 1,
                    Name = "35",
                    Description = "US = 4.5, UK = 2.5, 21.3 cm",
                },
                new Size
                {
                    Id = 2,
                    Name = "36",
                    Description = "US = 5.5, UK = 3.5, 22.2 cm",
                },
                new Size
                {
                    Id = 3,
                    Name = "37",
                    Description = "US = 4, UK = 4.5, 23 cm",
                },
                new Size
                {
                    Id = 4,
                    Name = "38",
                    Description = "US = 5, UK = 5.5, 23.8 cm",
                },
                new Size
                {
                    Id = 5,
                    Name = "39",
                    Description = "US = 6, UK = 6.5, 24.6 cm",

                },
                new Size
                {
                    Id = 6,
                    Name = "40",
                    Description = "US = 7, UK = 7.5, 25.4 cm",
                },
                new Size
                {
                    Id = 7,
                    Name = "41",
                    Description = "US = 8, UK = 8.5, 26.2 cm",
                },
                new Size
                {
                    Id = 8,
                    Name = "42",
                    Description = "US = 8, UK = 8.5, 26.2 cm",
                },
                new Size
                {
                    Id = 9,
                    Name = "43",
                    Description = "US = 8, UK = 8.5, 26.2 cm",
                },
                new Size
                {
                    Id = 10,
                    Name = "44",
                    Description = "US = 8, UK = 8.5, 26.2 cm",
                }
                );
        }
    }
}
