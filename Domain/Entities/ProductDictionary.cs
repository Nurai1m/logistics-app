﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductDictionary : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string VendorCode { get; set; }
        public List<ShopProduct> ShopProducts { get; set; }
    }
}
