using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    [Table("CartItem")]
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ProductItem))]
        public int ProductItemId { get; set; }
        public ProductItem? ProductItem { get; set; }

        [ForeignKey(nameof(Cart))]
        public int CartId { get; set;}
        public Cart? Cart { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
