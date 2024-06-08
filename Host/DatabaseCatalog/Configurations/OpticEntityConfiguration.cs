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
    public class OpticEntityConfiguration : IEntityTypeConfiguration<Optic>
    {
        public void Configure(EntityTypeBuilder<Optic> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).UseIdentityColumn(1, 1);

            builder.Property(o => o.RingDiameterUA).IsRequired().HasMaxLength(25).IsUnicode(true);

            builder.Property(o => o.RingDiameterENG).IsRequired().HasMaxLength(25).IsUnicode(false);

            builder.Property(o => o.Multiplicity).IsRequired().HasMaxLength(10).IsUnicode(false);

            builder.Property(o => o.ObjectiveLensDiameter).IsRequired();

            builder.Property(o => o.TypeOfReticle).IsRequired().HasMaxLength(30).IsUnicode(false);

            builder.Property(o => o.ReticleIllumination).IsRequired();

            builder.Property(o => o.AdjustmentOfParallax_FocusingUA).IsRequired().HasMaxLength(75).IsUnicode(true);

            builder.Property(o => o.AdjustmentOfParallax_FocusingENG).IsRequired().HasMaxLength(75).IsUnicode(false);

            builder.HasOne(cw => cw.Product)
                   .WithOne(pr => pr.Optic)
                   .HasForeignKey<Optic>(w => w.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
