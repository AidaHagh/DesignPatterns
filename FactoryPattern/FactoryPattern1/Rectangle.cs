﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern1
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle....");
        }
    }
}
