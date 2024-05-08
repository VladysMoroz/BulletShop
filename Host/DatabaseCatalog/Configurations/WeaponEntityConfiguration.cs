using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseCatalog.Configurations
{
    public class WeaponEntityConfiguration : IEntityTypeConfiguration<Weapon>
    {
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.ToTable("Weapons");

            builder.HasKey(w => w.Id);

            builder.Property(w => w.Id).UseIdentityColumn(1, 1);

            builder.Property(w => w.Caliber).IsRequired().HasMaxLength(20);

            builder.Property(w => w.MagazineCapacity).IsRequired();

            builder.Property(w => w.BarrelLength).IsRequired();

            builder.Property(w => w.GeneralLength).IsRequired();

            builder.Property(w => w.SightingDevicesUA).IsRequired().IsUnicode(true).HasMaxLength(100);

            builder.Property(w => w.SightingDevicesENG).IsRequired().IsUnicode(false).HasMaxLength(100);

            builder.Property(w => w.GunStockAndButtUA).IsRequired().IsUnicode(true).HasMaxLength(100);

            builder.Property(w => w.GunStockAndButtENG).IsRequired().IsUnicode(false).HasMaxLength(100);

            builder.Property(w => w.InitialVelocity).IsRequired();

            builder.Property(w => w.BarrelTwist).IsRequired().IsUnicode(false).HasMaxLength(30);

            builder.Property(w => w.TypeUA).IsRequired().IsUnicode(true).HasMaxLength(100);

            builder.Property(w => w.TypeENG).IsRequired().IsUnicode(false).HasMaxLength(100);

            builder.HasOne(w => w.Product)
                   .WithOne(pr => pr.Weapon)
                   .HasForeignKey<Weapon>(w => w.ProductId)
                   .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
