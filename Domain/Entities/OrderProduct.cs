using Domain.Common;

namespace Domain.Entities
{
    public class OrderProduct : BaseEntity
    {
        public Guid ShopProductId { get; set; }
        public ShopProduct ShopProduct { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public double Amount { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}