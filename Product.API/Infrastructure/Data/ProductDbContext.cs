using Microsoft.EntityFrameworkCore;
using Product.API.Core.Entities;



namespace Product.API.Infrastructure.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Productt> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Order>().HasOne(p => p.Product).WithMany(p => p.Orders);
        //}
    }
}
