using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage):base(beverage) 
        {
            
        }
        public override string Description
        {
            get
            {
                return beverage.Description + ", With Steamed Milk";
            }
        }

        public override double Cost()
        {
            return beverage.Cost() + 5;
        }
    }
}