using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class Orval : Beer
    {
        public Orval(int id, string name, string discription, double price, string img, int alcoholPercentage, bool isTrapist, string type)
            : base(id, name, discription, price, img, alcoholPercentage, isTrapist, type)
        {
        }
    }
}