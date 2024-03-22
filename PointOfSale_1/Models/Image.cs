using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_1.Models
{
    [Table("Image")]

    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public byte[] ImageBytes { get; set; }

        [MaxLength(100)]
        public string FileName { get; set; }

        [MaxLength(50)]
        public string ContentType { get; set; }
    }
}
