using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrystalClarityEyewearWebApp.Models
{
    public class ProductImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string Image { get; set; }

        public bool IsDefault { get; set; } 
    }
}
