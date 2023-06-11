using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Guid ShopLocationId { get; set; }
        public User Customer { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public string Description { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
        public Guid? СarrierId { get; set; }
        public User? Сarrier { get; set; }
        public string TreckingNumber { get; set; }
        public string? Address { get; set; }
        public string? Lat { get; set; }
        public string? Lang { get; set; }
        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
