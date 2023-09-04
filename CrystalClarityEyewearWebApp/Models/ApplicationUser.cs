using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CrystalClarityEyewearWebApp.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    //[Column(TypeName = "nvarchar")]
    //[StringLength(400)]
    //public string? Address { get; set; }

    [DataType(DataType.Date)]
    [DisplayName("Ngày sinh")]
    public DateTime? BirthDate { get; set; }

    [DisplayName("Hình đại diện")]
    public string? Avatar { get; set; }

    public ICollection<UserAddress> Addresses { get; set; }
}

