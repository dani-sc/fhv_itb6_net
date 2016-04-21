﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Service
{
    public class ProductSearch
    {
        // not static bc. there might be some configuration or caching later on
        // Additional parameter: "List of products called candidates"
        public ICollection<Product> Search(IEnumerable<Product> candidates, int? id = null, string number = null, string name = null,
            decimal? minPrice = null, decimal? maxPrice = null)
        {
            ICollection<Product> productsFiltered = candidates
                .Where(p => id == null || p.Id == id)
                .Where(p => number == null || p.Number == number)
                .Where(p => name == null || p.Name == name)
                .Where(p => minPrice == null || p.Price >= minPrice)
                .Where(p => maxPrice == null || p.Price <= maxPrice).ToList();

            return productsFiltered;
        } 
    }
}