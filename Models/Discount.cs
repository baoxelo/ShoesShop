using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    [Table("Discount")]
    public class Discount
    {
        [Key] public int Id { get; set; }

        [Required(ErrorMessage = "Cần thiết lập {0}")]
        [DisplayName("Tên mã giảm giá")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên {0} phải có độ dài từ {2} đến {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public required string Name { get; set; }

        [DisplayName("Mô tả")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(150)")]
        public string? Description { get; set; }

        [Column(TypeName = "int")]
        [Range(0, 80, ErrorMessage = "{0} không nhỏ hơn {1}% và không quá {2}%")]
        [DisplayName("Giảm giá")]
        public int? Percent { get; set; }

        [Column]
        [DisplayName("Ngày tạo")]
        public DateTime? CreateDate { get; set; }

        [DisplayName("Cập nhật lúc")]
        [Column]
        public DateTime? ModifyDate { get; set; }

        [DisplayName("Trạng thái")]
        [Column(TypeName = "nvarchar(10)")]
        [StringLength(10, ErrorMessage = "{0} có độ dài tối đa {1} ký tự")]
        public string? Status { get; set; }
    }
}
