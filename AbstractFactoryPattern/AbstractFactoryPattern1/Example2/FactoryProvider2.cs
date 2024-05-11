using AbstractFactoryPattern1.Example2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern1.Example2
{
    public class FactoryProvider2
    {
        public static IFurnitureAbstractFactory GetFactory(FurnitureType furnitureType)
        {
            IFurnitureAbstractFactory furnitureAbstractFactory = null;
            switch (furnitureType)
            {
                case FurnitureType.Art:
                    furnitureAbstractFactory=new ArtFurnitureFactory(); 
                    break;
                case FurnitureType.Classic:
                    furnitureAbstractFactory= new ClassicFurnitureFactory();
                    break;

            }
            return furnitureAbstractFactory;

        }
    }
}
