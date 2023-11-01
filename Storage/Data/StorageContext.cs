using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Storage.Models.Entities;

namespace Storage.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "iPhone 13", Description = "Latest iPhone model", Price = 999, Category = Category.Electronics, Shelf = "A1", Count = 30, OrderDate = DateTime.Parse("2023-10-15") },
                new Product { Id = 2, Name = "Samsung Galaxy S21", Description = "Flagship Android phone", Price = 899, Category = Category.Electronics, Shelf = "A2", Count = 20, OrderDate = DateTime.Parse("2023-10-16") },
                new Product { Id = 3, Name = "Sony PlayStation 5", Description = "Next-gen gaming console", Price = 499, Category = Category.Electronics, Shelf = "B1", Count = 10, OrderDate = DateTime.Parse("2023-10-17") },
                new Product { Id = 4, Name = "Nike Air Max 90", Description = "Classic sneakers", Price = 120, Category = Category.Clothing, Shelf = "B2", Count = 25, OrderDate = DateTime.Parse("2023-10-18") },
                new Product { Id = 5, Name = "Organic Apples", Description = "Fresh, organic apples", Price = 3, Category = Category.Groceries, Shelf = "C3", Count = 100, OrderDate = DateTime.Parse("2023-10-19") },
                new Product { Id = 6, Name = "HP Pavilion Laptop", Description = "Mid-range laptop", Price = 799, Category = Category.Electronics, Shelf = "C4", Count = 15, OrderDate = DateTime.Parse("2023-10-20") }
            );
        }
    }
}
