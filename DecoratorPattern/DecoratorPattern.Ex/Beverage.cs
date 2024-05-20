using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Ex
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string Description
        {
            get
            {
                return description;
            }
        }
        public abstract double Cost();
    }
}