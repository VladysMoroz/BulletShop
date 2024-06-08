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
    public class ColdWeaponEntityConfiguration : IEntityTypeConfiguration<ColdWeapon>
    {
        public void Configure(EntityTypeBuilder<ColdWeapon> builder)
        {
            builder.ToTable("ColdWeapons");

            builder.HasKey(cw => cw.Id);

            builder.Property(cw => cw.Id).UseIdentityColumn(1, 1);

            builder.Property(cw => cw.HandleMaterialUA).IsRequired().HasMaxLength(100).IsUnicode(true);

            builder.Property(cw => cw.HandleMaterialENG).IsRequired().HasMaxLength(100).IsUnicode(false);

            builder.Property(cw => cw.BladeMaterialUA).IsRequired().HasMaxLength(100).IsUnicode(true);

            builder.Property(cw => cw.BladeMaterialENG).IsRequired().HasMaxLength(100).IsUnicode(false);

            builder.Property(cw => cw.Hardness).IsRequired();

            builder.Property(cw => cw.LockUA).IsRequired().HasMaxLength(75).IsUnicode(true);

            builder.Property(cw => cw.LockENG).IsRequired().HasMaxLength(75).IsUnicode(false);

            builder.HasOne(cw => cw.Product)
                   .WithOne(pr => pr.ColdWeapon)
                   .HasForeignKey<ColdWeapon>(w => w.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
