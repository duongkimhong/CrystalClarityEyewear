using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class FeedBack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        public int? ProductId { get; set; }

        public double? Rating { get; set; }

        [DisplayName("Nội dung")]
        public string? Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? FeedBackDate { get; set; }

        public virtual ApplicationUser? User { get; set; }

        public virtual Product? Product { get; set; }
    }
}
