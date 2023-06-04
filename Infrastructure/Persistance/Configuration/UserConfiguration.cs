using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Firstname).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Patronymic).HasMaxLength(200);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.VehicleInfo).HasMaxLength(200);
        }
    }
}
