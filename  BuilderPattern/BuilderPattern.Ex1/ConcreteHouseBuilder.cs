using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern.Ex1
{
    public class ConcreteHouseBuilder : IHouseBuilder
    {
        private House house;

        public ConcreteHouseBuilder()
        {
            this.house = new House();
        }

        public void BuilderFoundation()
        {
            house.Foundation = "concrete, brick and stone";
            Console.WriteLine("ConcreteHouseBuilder:Foundation Complete");
        }
        public void BuilderStructure()
        {
            house.Structure = "concrete,mortar and steels";
            Console.WriteLine("ConcreteHouseBuilder:Structure Complete");
        }

        public void BuilderRoof()
        {
            house.Roof = "concrete and steel";
            Console.WriteLine("ConcreteHouseBuilder:Roof Complete");
        }

        public void PaintHouse()
        {
            house.Painted = true;
            Console.WriteLine("ConcreteHouseBuilder:Paint Complete");
        }

        public void FurnishHouse()
        {
            house.Furnished = false;
            Console.WriteLine("ConcreteHouseBuilder:Furnish Not Required");
        }

        public House GetHouse()
        {
            Console.WriteLine("ConcreteHouseBuilder:Concrete House Complete");
            return this.house;
        }


    }
}