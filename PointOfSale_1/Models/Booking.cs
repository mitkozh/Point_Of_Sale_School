using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSale_1.Models
{
    [Table("Booking")]
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Booking description is required.")]
        [MaxLength(50, ErrorMessage = "Booking description cannot exceed 50 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive integer.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Booking Date is required.")]
        public DateTime BookingDate { get; set; }


        [Required(ErrorMessage = "Customer is required.")]
        public virtual Customer Customer { get; set; }

        [Required(ErrorMessage = "Product is required.")]
        public virtual Product Product { get; set; }

        [NotMapped]
        public string ProductName => Product?.ItemName;

        [NotMapped]
        public string CustomerName => Customer?.Name;
    }
}
