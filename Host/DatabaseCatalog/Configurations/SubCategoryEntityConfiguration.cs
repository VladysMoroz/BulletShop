using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseCatalog.Configurations
{
    public class SubCategoryEntityConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.ToTable("SubCategories");

            builder.HasKey(sc => sc.Id);

            builder.Property(sc => sc.Id).UseIdentityColumn(1, 1);

            builder.Property(sc => sc.NameUA).IsRequired().IsUnicode(true).HasMaxLength(100);

            builder.Property(sc => sc.NameENG).IsRequired().IsUnicode(false).HasMaxLength(100);

            builder.HasOne(sc => sc.Category)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(sc => sc.CategoryId)
                   .IsRequired(true);
        }
    }
}
