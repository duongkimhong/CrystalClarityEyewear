using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Order : CommonAbstract
    {
        public Order() 
        { 
            this.OrderDetail = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        public decimal TotalAmount { get; set; }

        public int Quantity { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }

    }
}
