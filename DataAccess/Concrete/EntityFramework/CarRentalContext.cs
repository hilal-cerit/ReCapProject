using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-E57P7JU ; Database=CarRental;Trusted_Connection=true");
        }
      public DbSet<Car> Cars { get; set; }
       
        public DbSet<Color> Colors { get; set; }


         public DbSet<Brand> Brands { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
public DbSet<CarImage> CarImages { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CarImage>().ToTable("CarImages");
        //    modelBuilder.Entity<CarImage>().Property(p => p.CarImageId).HasColumnName("CarImageId");

        //    modelBuilder.Entity<CarImage>().Property(p => p.CarId).HasColumnName("CarId");
        //    modelBuilder.Entity<CarImage>().Property(p => p.ImageDate).HasColumnName("ImageDate");
        //    modelBuilder.Entity<CarImage>().Property(p => p.ImagePath).HasColumnName("ImagePath");
        //}

    }
}
