using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example2
{
    public class ArtFurnitureFactory : IFurnitureAbstractFactory
    {
        public IChair CreateChair()
        {
            IChair artChair=new ArtChair();
            return artChair;
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            ICoffeeTable artCoffeeTable=new ArtCoffeeTable();
            return artCoffeeTable;
        }

        public ISofa CreateSofa()
        {
            ISofa artSofa=new ArtSofa();    
            return artSofa;
        }
    }
}