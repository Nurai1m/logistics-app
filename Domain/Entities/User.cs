using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Firstname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<UserShop> UserShops { get; set; }
        public List<Order> CustomerOrders { get; set; }
        public List<Order> CarrierOrders { get; set; }
    }
}
