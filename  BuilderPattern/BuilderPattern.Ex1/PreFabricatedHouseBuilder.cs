using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern.Ex1
{
    public class PreFabricatedHouseBuilder : IHouseBuilder
    {
        private House house;

        public PreFabricatedHouseBuilder()
        {
            this.house = new House();
        }

        public void BuilderFoundation()
        {
            house.Foundation = "wood and laminate";
            Console.WriteLine("PreFabricatedHouseBuilder:Foundation Complete");
        }
        public void BuilderStructure()
        {
            house.Structure = "Structural wood and steels";
            Console.WriteLine("PreFabricatedHouseBuilder:Structure Complete");
        }

        public void BuilderRoof()
        {
            house.Roof = "Roofing Sheets";
            Console.WriteLine("PreFabricatedHouseBuilder:Roof Complete");
        }

        public void PaintHouse()
        {
            house.Painted = false;
            Console.WriteLine("PreFabricatedHouseBuilder:Painting  Not Required");
        }

        public void FurnishHouse()
        {
            house.Furnished = false;
            Console.WriteLine("PreFabricatedHouseBuilder:Furnish Not Required");
        }

        public House GetHouse()
        {
            Console.WriteLine("PreFabricatedHouseBuilder:Prefabricated House");
            return this.house;
        }


    }
}