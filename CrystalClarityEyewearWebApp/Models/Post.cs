using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? ShortContent { get; set; }

        public string? Content { get; set; }

        public string? Image { get; set; }

        public bool? IsPublish { get; set; }

        public DateTime? CreateDate { get; set; }

        public int UserId { get; set; }

        public string? Tags { get; set; }

        public int? CatPostId { get; set; }

        public bool? IsHot { get; set; }

        public bool? IsNewfeed { get; set; }

        public int? Views { get; set; }

        public virtual ApplicationUser? User { get; set; }

        public virtual PostCategory? CatPost { get; set; }
    }
}
