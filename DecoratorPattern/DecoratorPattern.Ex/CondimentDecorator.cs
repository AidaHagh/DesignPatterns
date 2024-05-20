using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
        public CondimentDecorator(Beverage beverage)
        {

            this.beverage = beverage;   

        }

        public override abstract double Cost();
    }
}