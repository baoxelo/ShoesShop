using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    [Table("Product")]
    public class Product 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cần thiết lập {0}")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên {0} phải có độ dài từ {2} đến {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public required string Name { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Mô tả")]
        [StringLength(255)]
        public string? Description { get; set; }

        [Column]
        [DisplayName("Giá sản phẩm")]
        public double? Price { get; set; }

        [Column]
        [DisplayName("Giá đã giảm")]
        public double? CurrentPrice { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Ảnh")]
        public string? ImageLink { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [DisplayName("Ảnh sản phẩm")]
        public IFormFile? ImageFile { get; set; }

        [ForeignKey(nameof(Category))]
        [DisplayName("Danh mục")]
        public int CategoryId { get; set; }

        [DisplayName("Danh mục")]
        public Category? Category { get; set; }

        [ForeignKey(nameof(Discount))]
        [DisplayName("Giảm giá")]
        public int DiscountId { get; set; }

        [DisplayName("Giảm giá")]
        public Discount? Discount { get; set; }


        [DisplayName("Đã bán")]
        [Column(TypeName = "int")]
        [Range(0, int.MaxValue, ErrorMessage = "Sản phẩm đã bán không nhỏ hơn {1}")]
        public int? Sold { get; set; }

        [ForeignKey(nameof(Gender))]
        [DisplayName("Giới tính")]
        public int GenderId { get; set; }
        public Gender? Gender { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255)]
        [DisplayName("Slug")]
        public string? Slug { get; set; }

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
        public List<ProductItem>? Items { get; set; }

        [NotMapped]
        public List<ProductImage>? Images { get; set; }
    }
}
