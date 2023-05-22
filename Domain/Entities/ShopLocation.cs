﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShopLocation : BaseEntity
    {
        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
