using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ILogisticEFContext
    {
        DbSet<Order> Orders { get; set; }
        DbSet<OrderProduct> OrderProducts { get; set; }
        DbSet<ProductDictionary> ProductDictionary { get; set; }
        DbSet<Shop> Shops { get; set; }
        DbSet<ShopLocation> ShopLocations { get; set; }
        DbSet<ShopProduct> ShopProducts { get; set; }
        DbSet<UserShop> UserShops { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);

        Task BeginTransactionAsync();

        Task CommitTransactionAsync();

        Task RollbackTransactionAsync();

    }
}
