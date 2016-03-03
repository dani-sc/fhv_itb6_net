﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        private string name;
        private string description;
        private decimal price;
        private Supplier supplier;
        private ProductCategory category;

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Supplier Supplier { get; set; }
        public ProductCategory Category { get; set; }
    }
}