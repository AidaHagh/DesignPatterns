using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso Coffee";
        }

        public override double Cost()
        {
            return 20;
        }
    }
}