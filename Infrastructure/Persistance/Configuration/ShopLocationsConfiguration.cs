using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configuration
{
    public class ShopLocationConfiguration : IEntityTypeConfiguration<ShopLocation>
    {
        public void Configure(EntityTypeBuilder<ShopLocation> builder)
        {
            builder.HasOne(x => x.Shop).WithMany(x => x.Locations).HasForeignKey(x => x.ShopId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(500);
        }
    }
}