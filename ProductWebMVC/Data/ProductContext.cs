using Microsoft.EntityFrameworkCore;
using ProductWebMVC.Models;

namespace ProductWebMVC.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):
            base(options){ }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id=1, Price=200m, Description="First Product"},
                new Product { Id = 2, Price = 250m, Description = "Second Product" }
                );
        }
    }
}
