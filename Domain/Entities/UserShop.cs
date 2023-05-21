using Domain.Common;

namespace Domain.Entities
{
    public class UserShop : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}