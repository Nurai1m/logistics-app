using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShopProduct : BaseEntity
    {
        public Guid ShopId { get; set; }
        public Guid ProductId { get; set; }
        public double Amount { get; set; }
    }
}
