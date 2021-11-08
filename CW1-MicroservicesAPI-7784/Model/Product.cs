﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW1_MicroservicesAPI_7784.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductCategoryId { get; set; }
        public Category ProductCategory { get; set; }
        public decimal Price { get; set; }
    }
}
