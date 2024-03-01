using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    public class ProductItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [DisplayName("Sản phẩm")]
        public Product? Product { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "{0} sản phẩm không được dưới {1}")]
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [ForeignKey(nameof(Size))]
        public int SizeId {  get; set; }

        [DisplayName("Size")]
        public Size? Size { get; set; }

    }
}
