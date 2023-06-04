﻿using Domain.Common;

namespace Domain.Entities
{
    public class ShopLocation : BaseEntity
    {
        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Lang { get; set; }
    }
}