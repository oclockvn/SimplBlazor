using System;
using System.Collections.Generic;
using System.Linq;
using SimplBlazor.Shared.Models;

namespace SimplBlazor.Shared
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalPrice => Products.Sum(p => p.Price);
        public string TotalPriceFormatted => TotalPrice.ToString("C");
    }
}
