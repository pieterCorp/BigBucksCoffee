﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    class IceTea : Soda
    {
        public IceTea(int id, string name, string discription, double price, string img, string extras, bool withSugar)
          : base(id, name, discription, price, img, extras, withSugar)
        {

        }
    }
}
