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
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasOne(e => e.User)
                 .WithMany(e => e.UserRoles)
                 .HasForeignKey(ur => ur.UserId)
                 .IsRequired();

            builder.HasOne(e => e.Role)
                 .WithMany(e => e.UserRoles)
                 .HasForeignKey(ur => ur.RoleId)
                 .IsRequired();
        }
    }
}
