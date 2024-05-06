using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternWithClassDiagram
{
    public class CarFactory
    {
        public ICar GetCar(string type)
        {
            ICar car = null;
            if (type.ToLower()=="bmw")
            {
                car = new Bmw();
            }else if (type.ToLower() == "benz")
            {
                car = new Benz();
            }
            else if(type.ToLower() =="toyota")
            {
                car=new Toyota();
            }
            else
            {
                throw new Exception("Not valid type");
            }
            return car; 
        }
    }
}