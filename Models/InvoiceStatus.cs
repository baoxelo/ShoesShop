using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesShop.Models
{
    [Table("InvoiceStatus")]
    public class InvoiceStatus
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Trạng thái")]
        public string? Status { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Mô tả")]
        public string? Description { get; set; }
    }
}
