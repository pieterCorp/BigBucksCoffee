﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    class Banana : Smoothie
    {
        public Banana (int id, string name, string description, double price, string img, bool extraFruits, int size)
              : base(id, name, description, price, img, extraFruits, size)
        {

        }
    }
}
