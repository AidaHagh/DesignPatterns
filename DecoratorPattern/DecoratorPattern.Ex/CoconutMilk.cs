using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public class CoconutMilk : CondimentDecorator
    {
        public CoconutMilk(Beverage beverage):base(beverage)
        {
            
        }
        public override string Description
        {
            get
            {
                return beverage.Description+ ", With Coconut Milk";
            }
        }
        public override double Cost()
        {
            return beverage.Cost()+10;
        }
    }
}