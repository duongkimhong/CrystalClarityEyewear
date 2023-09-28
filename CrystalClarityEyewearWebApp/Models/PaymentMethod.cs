using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrystalClarityEyewearWebApp.Models
{
    public class PaymentMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Image { get; set; }

        public string? BankAccNumber { get; set; }

        public string? BankAccName { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
