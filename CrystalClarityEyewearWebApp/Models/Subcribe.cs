using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Subcribe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
