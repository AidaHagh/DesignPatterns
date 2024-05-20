using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public class TurkCoffee : Beverage
    {
        public TurkCoffee()
        {
            description = "TurkCoffee Coffee";
        }

        public override double Cost()
        {
            return 22;
        }
    }
}