using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseCatalog.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(pr => pr.Id);

            builder.Property(pr => pr.Id).UseIdentityColumn(1, 1);

            builder.Property(pr => pr.NameUA).HasMaxLength(100).IsUnicode(true);

            builder.Property(pr => pr.NameENG).IsUnicode(false).HasMaxLength(100);

            builder.Property(pr => pr.ManufacturerUA).IsRequired().HasMaxLength(50).IsUnicode(true);

            builder.Property(pr => pr.ManufacturerENG).IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.Property(pr => pr.DescriptionUA).IsRequired().HasMaxLength(250).IsUnicode(true);

            builder.Property(pr => pr.DescriptionENG).IsRequired().IsUnicode(false).HasMaxLength(250);

            builder.Property(pr => pr.Weight).IsRequired().HasPrecision(10, 2);

            builder.Property(pr => pr.Photo).IsRequired().HasMaxLength(4000);

            builder.Property(pr => pr.Quantity).IsRequired();

            builder.Property(pr => pr.Price).IsRequired().HasPrecision(10, 2);

            builder.Property(pr => pr.OrderId).HasDefaultValue(0);

            builder.HasOne(pr => pr.SubCategory)
                   .WithMany(sc => sc.Products)
                   .HasForeignKey(pr => pr.SubCategoryId);
        }
    }
}
