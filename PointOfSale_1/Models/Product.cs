using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PointOfSale_1.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Item Barcode is required.")]
        [MaxLength(50, ErrorMessage = "Item Barcode cannot exceed 50 characters.")]
        public string ItemBarcode { get; set; }

        [Required(ErrorMessage = "Item Name is required.")]
        [MaxLength(50, ErrorMessage = "Item Name cannot exceed 50 characters.")]
        public string ItemName { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive integer.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Purchase Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Purchase Price must be greater than zero.")]
        public decimal PurchasePrice { get; set; }

        [Required(ErrorMessage = "Sales Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Sales Price must be greater than zero.")]
        public decimal SalesPrice { get; set; }

        [Range(0, 100, ErrorMessage = "Discount Rate must be between 0 and 100.")]
        public decimal DiscountRate { get; set; }

        [Required(ErrorMessage = "Expire Date is required.")]
        public DateTime ExpireDate { get; set; }

        [Required(ErrorMessage = "Manufacturing Date is required.")]
        public DateTime ManufacturingDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Weight must be a positive number.")]
        public decimal Weight { get; set; }

        [ForeignKey("Image")]
        public int ImageId { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Image is required.")]

        public virtual Image Image { get; set; }

        [Required(ErrorMessage = "Supplier is required.")]
        public virtual Supplier Supplier { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public virtual Category Category { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
