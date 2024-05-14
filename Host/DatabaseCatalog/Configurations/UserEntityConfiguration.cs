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
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).UseIdentityColumn(1, 1);

            builder.Property(u => u.UserName).IsRequired().HasMaxLength(100);

            builder.Property(u => u.Email).IsRequired().HasMaxLength(255);

            builder.Property(u => u.PasswordHash).IsRequired().HasMaxLength(64);
        }
    }
}
