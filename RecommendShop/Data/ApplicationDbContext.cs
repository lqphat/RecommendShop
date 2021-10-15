using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecommendShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecommendShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProductModel>().HasKey(p => p.Id);
        //    modelBuilder.Entity<ReviewModel>().HasKey(r => r.Id);
        //    modelBuilder.Entity<CategoryModel>().HasKey(c => c.Id);
        //    modelBuilder.Entity<AttributeModel>().HasKey(a => a.id);

        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<AttributeModel> Attributes { get; set; }

    }
}
