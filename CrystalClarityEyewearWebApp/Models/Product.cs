using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrystalClarityEyewearWebApp.Models
{
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? ShortDesc { get; set; }

        public string? Description { get; set; }

        public int CatId { get; set; }

        public decimal? Price { get; set; }

        public int? UnitInStock { get; set; }

        public double? SaleDiscount { get; set; }

        public string? Image { get; set; }

        public string? Video { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? IsBestSeller { get; set; }

        public bool? IsHomeFlag { get; set; }

        public bool? IsPublish { get; set; }

        public string? Tags { get; set; }

        [ForeignKey("CatId")]
        public Category Category { get; set; }

        public virtual ICollection<FeedBack> FeedBacks { get; set; } = new List<FeedBack>();

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}


