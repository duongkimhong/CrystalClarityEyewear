using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Advertisement : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)] 
        public string Title { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        public int Type { get; set; }   
    }
}
