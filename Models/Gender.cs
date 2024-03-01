using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoesShop.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Loại giới tính")]
        [Column(TypeName = "nvarchar(15)")]
        public string? GenderType { get; set; }


        [NotMapped]
        public List<Product> Products { get; set; }

    }
}
