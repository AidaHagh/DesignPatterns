using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public class DeCof : Beverage
    {
        public DeCof()
        {
            description = "DeCof Coffee";
        }
        public override double Cost()
        {
            return 25;
        }
    }
}