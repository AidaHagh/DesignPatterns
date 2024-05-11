using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern.Ex1
{
    public class ConstructionEngineer
    {
        private IHouseBuilder houseBuilder;

        public ConstructionEngineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public House ConstructHouse()
        {
            houseBuilder.BuilderFoundation();
            houseBuilder.BuilderStructure();
            houseBuilder.BuilderRoof();
            houseBuilder.PaintHouse();
            houseBuilder.FurnishHouse();
            return houseBuilder.GetHouse(); 

        }
    }
}