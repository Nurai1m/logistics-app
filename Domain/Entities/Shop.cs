using Domain.Common;

namespace Domain.Entities
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<UserShop> UserShops { get; set; }
        public List<ShopProduct> ShopProducts { get; set; }
        public List<ShopLocation> Locations { get; set; }
    }
}