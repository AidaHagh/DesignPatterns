using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern.Ex1
{
    public interface IHouseBuilder
    {
        void BuilderFoundation();
        void BuilderStructure();
        void BuilderRoof();
        void PaintHouse();
        void FurnishHouse();
        House GetHouse();   
    }
}