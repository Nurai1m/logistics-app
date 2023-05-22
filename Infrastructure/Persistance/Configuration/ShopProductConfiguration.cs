using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configuration
{
    public class ShopProductConfiguration : IEntityTypeConfiguration<ShopProduct>
    {
        public void Configure(EntityTypeBuilder<ShopProduct> builder)
        {
            builder.HasOne(x => x.Product).WithMany(x => x.ShopProducts).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Shop).WithMany(x => x.ShopProducts).HasForeignKey(x => x.ShopId);
        }
    }
}