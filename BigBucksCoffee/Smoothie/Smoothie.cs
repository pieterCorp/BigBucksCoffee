using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class Smoothie : Beverages
    {
        public bool ExtraFruits { get; set; }
        public int Size { get; set; }

        public Smoothie(int id, string name, string discription, double price, string img, bool extraFruits, int size)
            : base(id, name, discription, price, img)
        {
            ExtraFruits = extraFruits;
            Size = size;
        }
    }
}