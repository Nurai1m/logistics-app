using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderProduct
    {
        public Guid ShopProductId { get; set; }
        public Guid OrderId { get; set; }
        public double Amount { get; set; }
    }
}
