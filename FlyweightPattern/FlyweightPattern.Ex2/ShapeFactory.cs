using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern.Ex2
{
    public class ShapeFactory
    {
        private static Dictionary<string,IShape> shapeMap= new Dictionary<string,IShape>(); 

        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;
            if (shapeType.Equals("circle",StringComparison.InvariantCultureIgnoreCase))
            {
                if (shapeMap.TryGetValue("circle",out shape))
                {
                    shape = shapeMap["circle"];
                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add("circle", shape); 
                    Console.WriteLine("creating circle object with out any color ");
                }
            }
            return shape;
        }

        public static int GetCount()
        {
            return shapeMap.Count;

        }
    }
}