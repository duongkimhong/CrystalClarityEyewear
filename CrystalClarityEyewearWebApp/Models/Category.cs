using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatId { get; set; }

        [Required]
        [DisplayName("Tên danh mục")]
        public string Name { get; set; }

        [DisplayName("Mô tả")]
        public string? Description { get; set; }

        public int? ParentId { get; set; }

        public int? Levels { get; set; }

        public int? Ordering { get; set; }

        public bool? IsPublish { get; set; }

        [DisplayName("Hình ảnh")]
        public string? Image { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Category> Subcategories { get; set; } = new List<Category>();

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
