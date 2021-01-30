using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    public class ItemInCart
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public double SinglePrice { get; set; }
        public double TotalPrice { get; set; }
    }
}