using Core.Entities;
using DatabaseCatalog.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCatalog
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new WeaponEntityConfiguration());
        }
    }
}
