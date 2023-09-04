using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Province
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProvinceId { get; set; }

        [Required]
        [DisplayName("Tỉnh / Thành phố")]
        public string ProvinceName { get; set; }

        public List<District> Districts { get; set; }
    }
}
