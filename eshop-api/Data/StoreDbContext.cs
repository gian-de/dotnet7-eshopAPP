using System;
using ecomAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecomAPI.Data
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //	base.OnModelCreating(modelBuilder);

        //	// 1 to many
        //	modelBuilder.Entity<Product>()
        //		.HasMany(p => p.ProductVariants)
        //		.WithOne(pv => pv.Product)
        //		.HasForeignKey(pv => pv.ProductId)
        //		.OnDelete(DeleteBehavior.Cascade);

        //	// 1 to many
        //	modelBuilder.Entity<ProductVariant>()
        //		.HasMany(pv => pv.ProductImages)
        //              .WithOne(pi => pi.ProductVariant)
        //		.HasForeignKey(pi => pi.ProductVariantId)
        //		.OnDelete(DeleteBehavior.Cascade);

        //	// rename tables to snake_case
        //	modelBuilder.Entity<ProductVariant>()
        //		.ToTable("product_variant");

        //	modelBuilder.Entity<Product>()
        //		.ToTable("products");

        //	modelBuilder.Entity<ProductImage>()
        //		.ToTable("product_images");
        //}
    }
}

