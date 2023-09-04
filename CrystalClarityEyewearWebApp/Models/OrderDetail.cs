using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? OrderId { get; set; }

        public int? ProductId { get; set; }

        [DisplayName("Số lượng")]    
        public int? Quantity { get; set; }

        public double? Discount { get; set; }

        [DisplayName("Tổng cộng")]
        public decimal? Total { get; set; }

        public virtual Order? Order { get; set; }

        public virtual Product? Product { get; set; }
    }
}
