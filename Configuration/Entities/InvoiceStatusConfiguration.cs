using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoesShop.Models;

namespace ShoesShop.Configuration.Entities
{
    public class InvoiceStatusConfiguration : IEntityTypeConfiguration<InvoiceStatus>
    {
        public void Configure(EntityTypeBuilder<InvoiceStatus> builder)
        {
            builder.HasData(
                new InvoiceStatus
                {
                    Id = 1,
                    Status = "Đang chờ xác nhận",
                    Description ="Chúng tôi sẽ sớm liên hệ với bạn"
                },
                new InvoiceStatus
                {
                    Id = 2,
                    Status = "Đang giao",
                    Description = "Đơn hàng đang được vận chuyển đến bạn"
                },
                new InvoiceStatus
                {
                    Id = 3,
                    Status = "Hoàn tất",
                    Description = "Đơn hàng đã được hoàn tất"
                },
                new InvoiceStatus
                {
                    Id = 4,
                    Status = "Đơn hàng bị hủy",
                    Description = "Đơn hàng đã bị hủy"
                }
                );
        }
    }
}
