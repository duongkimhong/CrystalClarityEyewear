using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrystalClarityEyewearWebApp.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public string Alias { get; set; }

        public string SeoTitle { get; set; }

        public string SeoDescription { get; set; }

        public string SeoKeywords { get; set; }

        public int Position { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
