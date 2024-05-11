using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example2
{
    public class ClassicFurnitureFactory : IFurnitureAbstractFactory
    {
        public IChair CreateChair()
        {
            IChair classicChair=new ClassicChair();
            return classicChair;    
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            ICoffeeTable classicCoffeeTable=new ClassicCoffeeTable();   
            return classicCoffeeTable;
        }

        public ISofa CreateSofa()
        {
            ISofa classicSofa=new ClassicSofa();
            return classicSofa;
        }
    }
}