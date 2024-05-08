using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseCatalog.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseIdentityColumn(1, 1);

            builder.Property(c => c.NameUA).IsRequired().IsUnicode(true).HasMaxLength(100);

            builder.Property(c => c.NameENG).IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }
}
