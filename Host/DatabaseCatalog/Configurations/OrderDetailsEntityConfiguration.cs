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
    public class OrderDetailsEntityConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(od => od.Id);

            builder.Property(od => od.Id).UseIdentityColumn(1, 1);

            builder.Property(od => od.Price).IsRequired().HasPrecision(7, 2);
        }
    }
}
