using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string OldPrice { get; set; }
        public bool Discount { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Count { get; set; }
    }
}
