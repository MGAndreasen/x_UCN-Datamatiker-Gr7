using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Product[] ProductArray { get; set; }
        public ProductGroup ProductGroup { get; set; }
    }
}
