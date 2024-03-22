using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        [Index(IsUnique = true)]
        public string Name { get; set; }


        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}
