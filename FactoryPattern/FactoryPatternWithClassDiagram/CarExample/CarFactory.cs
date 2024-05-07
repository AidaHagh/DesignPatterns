using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternWithClassDiagram.CarExample
{
    public class CarFactory
    {
        public ICar GetCar(string type)
        {
            ICar car = null;
            if (type.ToLower() == "bmw")
            {
                car = new Bmw();
            }
            else if (type.ToLower() == "benz")
            {
                car = new Benz();
            }
            else if (type.ToLower() == "toyota")
            {
                car = new Toyota();
            }
            else
            {
                throw new Exception("Not valid type");
            }
            return car;
        }
    }
}
//وقتی چند کلاس متد یکسان دارند و کار مشابهی انجام میدهند 
// یک کلاس مشترک از جنس اینترفیس آن کلاس ها درست میکنیم و هرکجا که 
// به آن کلاسها نیاز داشته باشیم میتوانیم با ساخت آبجکت ازآن کلاس مشترک به همه
//  (کلاسها دسترسی داشته باشیم (همه کلاس ها از یک اینترفیس ارث بری میکنند
