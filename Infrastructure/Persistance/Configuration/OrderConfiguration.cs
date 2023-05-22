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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(x => x.Customer).WithMany(x => x.CustomerOrders).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Сarrier).WithMany(x => x.CarrierOrders).HasForeignKey(x => x.СarrierId);
            builder.Property(x => x.DeliveryType).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.TreckingNumber).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(1000);
        }
    }
}
