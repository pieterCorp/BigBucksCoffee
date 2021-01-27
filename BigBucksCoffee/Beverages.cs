using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    abstract class Beverages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Discription { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public Beverages(int id , string name, string discription, double price, string img)
        {
            Id = id;
            Name = name;
            Discription = discription;
            Price = price;
            Image = img;

        }        

        virtual public string ToString()
        {
            return $"{Id}{Name}{Discription}{Price}{Image}";
        }
    }
}
