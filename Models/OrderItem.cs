using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanoo.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        public int OrderId { get; set; } = 0;

        [Required]
        public string Service { get; set; } = String.Empty;

        [Required]
        public string Description { get; set; } = String.Empty;

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; } = 0.00M;

        [Required]
        public int Quantity { get; set; } = 0;

        // There will be ONE order to MANY order ITEMS
        [ForeignKey("OrderId")]
        public virtual Order? Order { get; set; }

    }
}