using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CrystalClarityEyewearWebApp.Models
{
    public class AppContext : IdentityDbContext<ApplicationUser>
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            builder.Entity<UserAddress>()
            .HasOne(ua => ua.User)
            .WithMany(u => u.Addresses)
            .HasForeignKey(ua => ua.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade); // Để xóa địa chỉ khi người dùng bị xóa

            builder.Entity<Category>()
            .HasMany(c => c.Subcategories)
            .WithOne(p => p.ParentCategory)
            .OnDelete(DeleteBehavior.Restrict); // Chọn DeleteBehavior.Restrict để tắt Cascade Delete

            builder.Entity<UserAddress>()
            .HasOne(ua => ua.Province)
            .WithMany()
            .HasForeignKey(ua => ua.ProvinceId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserAddress>()
            .HasOne(ua => ua.Ward)
            .WithMany()
            .HasForeignKey(ua => ua.WardId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CatId);

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Ward> Wards { get; set; }
    }
}
