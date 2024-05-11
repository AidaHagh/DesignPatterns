using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example2
{
    public class ArtCoffeeTable : ICoffeeTable
    {
        public void DrinkCoffee()
        {
            Console.WriteLine("DrinkCoffee:ArtCoffeeTable");
        }
    }
}