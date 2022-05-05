using System;
using System.Collections.Generic;
using System.Text;

namespace PCKSystem.Model
{
    internal class Orders
    {
        public int productId { get; set; }
        public string product { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
    }
}
