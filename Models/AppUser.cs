using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoesShop.Models
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "Cần thiết lập {0}")]
        [DisplayName("Tên đầy đủ")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên {0} phải có độ dài từ {2} đến {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public required string FullName { get; set; }

        [DisplayName("Ảnh đại diện")]
        [Column(TypeName = "nvarchar(500)")]
        public string? Avatar {  get; set; }

        [DisplayName("Ngày sinh")]
        [Column(TypeName = "date")]
        public DateOnly? BirthDate { get; set; }

        [DisplayName("Địa chỉ")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Tên {0} phải có độ dài từ {2} đến {1}")]
        [Column(TypeName = "nvarchar(255)")]
        public string? Address { get; set; }

        [NotMapped]
        public Cart? Cart { get; set; }

    }
}
