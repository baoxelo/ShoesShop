using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    [Table("Cart")]
    public class Cart
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
        public List<CartItem>? CartItems { get; set;}
    }
}
