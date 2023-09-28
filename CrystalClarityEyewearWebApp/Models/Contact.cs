using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Tên không được để trống")]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        [StringLength (5000)] 
        public string Message { get; set; }

        public string IsRead { get; set; }
    }
}
