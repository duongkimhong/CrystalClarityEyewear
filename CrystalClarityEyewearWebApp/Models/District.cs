using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class District
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DistrictId { get; set; }

        [DisplayName("Quận / Huyện")]
        public string DistrictName { get; set; }

        public int ProvinceId { get; set; }

        public Province Province { get; set; }

        public List<Ward> Wards { get; set; }
    }
}
