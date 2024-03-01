using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    public class Size
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cần thiết lập {0}")]
        [DisplayName("Size")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tên {0} phải có độ dài từ {2} đến {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public required string Name { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Mô tả kích thước")]
        [StringLength(150)]
        public string? Description { get; set; }

    }
}
