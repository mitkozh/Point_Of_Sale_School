using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Models
{
    public class Customer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        public string Name { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }

    
}
