using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal abstract class Beverage : IBeverage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public Beverage(int id, string name, string discription, double price, string img)
        {
            ID = id;
            Name = name;
            Discription = discription;
            Price = price;
            Image = img;
        }

        override public string ToString()
        {
            return $"{ID}{Name}{Discription}{Price}{Image}";
        }
    }
}