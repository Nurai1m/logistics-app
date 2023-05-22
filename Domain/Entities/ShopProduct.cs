using Domain.Common;

namespace Domain.Entities
{
    public class ShopProduct : BaseEntity
    {
        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }
        public Guid ProductId { get; set; }
        public ProductDictionary Product { get; set; }
        public double Amount { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}