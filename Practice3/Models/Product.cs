﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        
        public System.DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}