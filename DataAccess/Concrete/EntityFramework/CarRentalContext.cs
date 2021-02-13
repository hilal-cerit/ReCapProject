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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Brand>().ToTable("Brands");
        //    modelBuilder.Entity<Brand>().Property(p => p.BrandId).HasColumnName("BrandId");

        //    modelBuilder.Entity<Brand>().Property(p => p.BrandName).HasColumnName("BrandName");
        //}

    }
}
