using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoesShop.Models
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(AppUser))]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Mã đơn hàng")]
        public string? InvoiceCode { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} phải có độ dài từ {2} đến {1}")]
        [DisplayName("Tên người nhận")]
        public string? CustomerName { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "{0} phải có độ dài từ {2} đến {1}")]
        [DisplayName("Địa chỉ giao hàng")]
        public string? Address { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Liên hệ")]
        public string? Phone { get; set; }

        [Column]
        [DisplayName("Tổng chi tiêu")]
        public double? TotalPrice { get; set; }

        [Column]
        [DisplayName("Ngày đặt hàng")]
        public DateTime DateOrdered { get; set; }

        [ForeignKey(nameof(InvoiceStatus))]
        public int StatusId { get; set; }
        public InvoiceStatus? Status { get; set; }

        [NotMapped]
        public List<InvoiceItem>? InvoiceItems { get; set; }
    }
}
