using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Category : CommonAbstract
    {
        public Category() 
        { 
            this.News = new HashSet<News>();
            this.Post = new HashSet<Post>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string? Description { get; set; }

        public string? Icon { get; set; }

        public string? Alias { get; set; }

        public string? SeoTitle { get; set; }

        public string? SeoDescription { get; set; }

        public string? SeoKeywords { get; set; }

        public int Position { get; set; }

        public bool IsActive { get; set; }

        public ICollection<News> News { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
