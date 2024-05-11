using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example2
{
    public class ClassicCoffeeTable : ICoffeeTable
    {
        public void DrinkCoffee()
        {
            Console.WriteLine("DrinkCoffee:ClassicCoffeeTable");

        }
    }
}