using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public class Cream : CondimentDecorator
    {
        public Cream(Beverage beverage):base(beverage)
        {
            
        }
        public override string Description
        {
            get
            {
                return beverage.Description + ", With Cream";
            }
        }
        public override double Cost()
        {
            return beverage.Cost() + 7;
        }
    }
}