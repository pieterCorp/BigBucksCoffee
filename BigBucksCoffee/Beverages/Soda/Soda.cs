using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal abstract class Soda : Beverage
    {
        public string Extras { get; set; }
        public bool WithSugar { get; set; }

        public Soda(int id, string name, string discription, double price, string img, string extras, bool withSugar)
            : base(id, name, discription, price, img)
        {
            Extras = extras;
            WithSugar = withSugar;
        }
    }
}