using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Ward
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WardId { get; set; }

        [DisplayName("Xã")]
        [Required]
        public string WardName { get; set; }

        public int DistrictId { get; set; }

        public District District { get; set; }
    }
}
