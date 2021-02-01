using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    public abstract class Beer : Beverage
    {
        public int AlcoholPercentage { get; set; }
        public bool IsTrapist { get; set; }
        public string Type { get; set; }

        public Beer(int id, string name, string description, double price, string img, int alcoholPercentage, bool isTrapist, string type)
            : base(id, name, description, price, img)
        {
            AlcoholPercentage = alcoholPercentage;
            IsTrapist = isTrapist;
            Type = type;
        }
    }
}