using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Link ảnh")]
        [Column(TypeName = "nvarchar(255)")]
        public string? ImageLink { get; set; }

        
        [NotMapped]
        [DisplayName("File ảnh")]
        public IFormFile? ImageFile { get; set; }


        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
