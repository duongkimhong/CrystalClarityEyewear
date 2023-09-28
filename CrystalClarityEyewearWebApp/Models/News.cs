using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CrystalClarityEyewearWebApp.Models
{
    public class News : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [AllowHtml]
        public string Detail { get; set; }

        public string? Image { get; set; }
        [NotMapped] // Đánh dấu thuộc tính này để nó không được ánh xạ vào cơ sở dữ liệu
        public IFormFile? CoverImage { get; set; }

        public string? Alias { get; set; }

        public int? CategoryId { get; set; }

        public string? SeoTitle { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoKeywords { get; set; }

        public bool IsActive { get; set; }

        public virtual Category? Category { get; set; }
    }
}
