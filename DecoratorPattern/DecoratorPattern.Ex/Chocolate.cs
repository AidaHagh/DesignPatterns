using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public class Chocolate : CondimentDecorator
    {
        public Chocolate(Beverage beverage):base(beverage)
        {
            
        }
        public override string Description
        {
            get
            {
                return beverage.Description + ", With Chocolate";
            }
        }
        public override double Cost()
        {
            return beverage.Cost() + 7;
        }
    }
}