using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        [DisplayName("Ngày đặt")]
        public DateTime? OrderDate { get; set; }

        [DisplayName("Trạng thái")]
        public string? Status { get; set; }

        public bool? IsDeleted { get; set; }

        public decimal? Discount { get; set; }

        public bool? Paid { get; set; }

        public int? PaymentId { get; set; }

        [DisplayName("Ghi chú")]
        public string? Note { get; set; }

        public int? StaffId { get; set; }

        public virtual ICollection<ApplicationUser> User { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public virtual PaymentMethod? Payment { get; set; }

    }
}
