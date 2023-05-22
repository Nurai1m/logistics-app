using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configuration
{
    public class UserShopConfiguration : IEntityTypeConfiguration<UserShop>
    {
        public void Configure(EntityTypeBuilder<UserShop> builder)
        {
            builder.HasOne(x => x.User).WithMany(x => x.UserShops).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Shop).WithMany(x => x.UserShops).HasForeignKey(x => x.ShopId);
        }
    }
}