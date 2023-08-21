﻿using CrystalClarityEyewearWebApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CrystalClarityEyewearWebApp.Models;

namespace CrystalClarityEyewearWebApp.Areas.Identity.Data;

public class AppContext : IdentityDbContext<ApplicationUser>
{
    public AppContext(DbContextOptions<AppContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            var tableName = entityType.GetTableName();
            if (tableName.StartsWith("AspNet"))
            {
                entityType.SetTableName(tableName.Substring(6));
            }
        }
    }

    //public DbSet<CrystalClarityEyewearWebApp.Models.Product> Product { get; set; } = default!;
    public DbSet<Product> Product { get; set; }
    
}
