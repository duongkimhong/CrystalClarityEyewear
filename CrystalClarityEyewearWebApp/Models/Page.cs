using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CrystalClarityEyewearWebApp.Models
{
    public class Page
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Content { get; set; }

        public string? Image { get; set; }

        public bool? IsPublish { get; set; }

        public int? Ordering { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}

