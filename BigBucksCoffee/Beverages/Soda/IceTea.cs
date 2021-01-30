using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class IceTea : Soda
    {
        public bool WithLemon { get; set; }

        public IceTea(int id, string name, string discription, double price, string img, string extras, bool withSugar, bool withLemon)
          : base(id, name, discription, price, img, extras, withSugar)
        {
            WithLemon = withLemon;
        }
    }
}