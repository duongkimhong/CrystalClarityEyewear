using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CrystalClarityEyewearWebApp.Models
{
    public partial class Product : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ProductCode { get; set; }

        public string? ShortDesc { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public string Alias { get; set; }

        public decimal Price { get; set; }

        public decimal PriceSale { get; set; }

        public bool IsHome { get; set; }

        public bool IsSale { get; set; }

        public bool IsFeatture { get; set; }

        public bool IsHot { get; set; }

        public int CatId { get; set; }

        public string SeoTitle { get; set; }

        public string SeoDescription { get; set; }

        public string SeoKeywords { get; set; }

        public int Quantity { get; set; }

        public bool IsBestSeller { get; set; }

        public bool IsPublish { get; set; }



        public virtual ProductCategory ProductCategory { get; set; }


        
    }
}


