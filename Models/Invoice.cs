using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoesShop.Models
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(AppUser))]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        [Column]
        [DisplayName("Tổng chi tiêu")]
        public double TotalPrice { get; set; }

        [NotMapped]
        public List<CartItem>? InvoiceItems { get; set; }
    }
}
