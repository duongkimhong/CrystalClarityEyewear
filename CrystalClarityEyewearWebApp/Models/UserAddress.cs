using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class UserAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        [Required]
        public int DistrictId { get; set; }
        public District District { get; set; }

        [Required]
        public int WardId { get; set; }
        public Ward Ward { get; set; }

        [DisplayName("Quốc gia")]
        [Required]
        public string Country { get; set; }
        public bool IsDefault { get; set; }

        // Khóa ngoại đến bảng AspNetUsers
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
