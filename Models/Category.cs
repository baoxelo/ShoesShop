using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cần thiết lập {0}")]
        [DisplayName("Tên danh mục")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên {0} phải có độ dài từ {2} đến {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public required string Name { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Mô tả")]
        [StringLength(255)]
        public string? Description { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255)]
        [DisplayName("Slug")]
        public string? Slug { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Ảnh")]
        public string? ImageLink { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [DisplayName("Ảnh sản phẩm")]
        public IFormFile? ImageFile { get; set; }

        [Column]
        [DisplayName("Ngày tạo")]
        public DateTime? CreateDate { get; set; }

        [DisplayName("Cập nhật lúc")]
        [Column]
        public DateTime? ModifyDate { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Trạng thái")]
        [StringLength(10)]
        public string? Status { get; set; }

        [NotMapped]
        public List<Product>? Products { get; set; }
    }
}
