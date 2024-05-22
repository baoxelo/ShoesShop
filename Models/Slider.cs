using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoesShop.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cần thiết lập {0}")]
        [DisplayName("Tên slide")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Tên {0} phải có độ dài từ {2} đến {1}")]
        [Column(TypeName = "nvarchar(255)")]
        public required string Title { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Mô tả")]
        [StringLength(255)]
        public string? Description { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [DisplayName("Ảnh slide")]
        public IFormFile? ImageFile { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Ảnh")]
        public string? ImageLink { get; set; }


        [Column]
        [DisplayName("Ngày tạo")]
        public DateTime? CreateDate { get; set; }

        [DisplayName("Cập nhật lúc")]
        [Column]
        public DateTime? ModifyDate { get; set; }
    }
}
