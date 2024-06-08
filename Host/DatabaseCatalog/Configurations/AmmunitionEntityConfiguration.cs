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
    public class AmmunitionEntityConfiguration : IEntityTypeConfiguration<Ammunition>
    {
        public void Configure(EntityTypeBuilder<Ammunition> builder)
        {
            builder.HasKey(amm => amm.Id);

            builder.Property(amm => amm.Id).UseIdentityColumn(1, 1);

            builder.Property(amm => amm.ColorUA).HasMaxLength(50).IsUnicode(true);

            builder.Property(amm => amm.ColorENG).HasMaxLength(50).IsUnicode(false);

            builder.Property(amm => amm.ProtectionLevelUA).HasMaxLength(15).IsUnicode(true).IsRequired(false);

            builder.Property(amm => amm.ProtectionLevelENG).HasMaxLength(15).IsUnicode(false).IsRequired(false);

            builder.Property(amm => amm.GenderUA).HasMaxLength(15).IsUnicode(true).IsRequired(false);

            builder.Property(amm => amm.GenderENG).HasMaxLength(15).IsUnicode(false).IsRequired(false);

            builder.Property(amm => amm.SizeUA).HasMaxLength(10).IsUnicode(true).IsRequired(false);

            builder.Property(amm => amm.SizeENG).HasMaxLength(10).IsUnicode(false).IsRequired(false);

            builder.Property(amm => amm.SeasonUA).HasMaxLength(10).IsUnicode(true).IsRequired(false);

            builder.Property(amm => amm.SeasonENG).HasMaxLength(10).IsUnicode(false).IsRequired(false);

            builder.HasOne(amm => amm.Product)
                .WithOne(pr => pr.Ammunition)
                .HasForeignKey<Ammunition>(amm => amm.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
