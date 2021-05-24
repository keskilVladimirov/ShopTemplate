using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Count { get; set; }
        public string Adress { get; set; }
        public string DateTime { get; set; }
    }
}
