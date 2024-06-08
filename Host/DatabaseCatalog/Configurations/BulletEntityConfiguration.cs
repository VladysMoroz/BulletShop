using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCatalog.Configurations
{
    public class BulletEntityConfiguration : IEntityTypeConfiguration<Bullet>
    {
        public void Configure(EntityTypeBuilder<Bullet> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id).UseIdentityColumn(1, 1);

            builder.Property(b => b.Caliber).IsRequired().HasMaxLength(20).IsUnicode(false);

            builder.Property(b => b.BulletWeight).IsRequired().HasPrecision(10, 2);

            builder.Property(b => b.QuantityInPackage).IsRequired();

            builder.HasOne(b => b.Product)
                .WithOne(pr => pr.Bullet)
                .HasForeignKey<Bullet>(b => b.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
