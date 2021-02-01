using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal abstract class Smoothie : Beverage
    {
        public bool ExtraFruits { get; set; }
        public int Size { get; set; }

        public Smoothie(int id, string name, string description, double price, string img, bool extraFruits, int size)
            : base(id, name, description, price, img)
        {
            ExtraFruits = extraFruits;
            Size = size;
        }
    }
}