using Microsoft.EntityFrameworkCore;
using ProductAgent.Domain.Models;

namespace ProductAgent.Infrastructure
{
    public class ProductRepository
        : DbContext
    {

        public ProductRepository(DbContextOptions<ProductRepository> options)
            : base(options)
        {
            
        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Define a Table Name in the DB Based on model Object
            modelBuilder.Entity<ProductModel>().ToTable("Products");


            //Fill data to the Model that values automatically insert into db
            modelBuilder.Entity<ProductModel>().HasData(

                    new ProductModel()
                    {
                        Id = Guid.NewGuid(),
                        ProductName = "Dell Inspiron 15",
                        Category = "Laptop",
                        Price = 45000,
                        Quantity = 20
                    },
                     new ProductModel()
                     {
                         Id = Guid.NewGuid(),
                         ProductName = "HP Pavilion 14",
                         Category = "Laptop",
                         Price = 72000,
                         Quantity = 15
                     },
                     new ProductModel()
                     {
                         Id = Guid.NewGuid(),
                         ProductName = "Lenovo IdeaPad Slim",
                         Category = "Laptop",
                         Price = 58000,
                         Quantity = 8
                     }

                );
        }
    }
}
