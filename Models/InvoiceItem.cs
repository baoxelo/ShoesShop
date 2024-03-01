using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoesShop.Models
{
    [Table("InvoiceItem")]
    public class InvoiceItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ProductItem))]
        public int ProductItemId { get; set; }
        public ProductItem? ProductItem { get; set; }

        [ForeignKey(nameof(Invoice))]
        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
