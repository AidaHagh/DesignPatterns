using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern1
{
    public class ShapeFactory
    {
        public IShape GetShape(string type)
        {
            if (type.ToLower() == "circle")
                return new Circle();
            else if (type.ToLower() == "rectangle")
                return new Rectangle(); 
            else if (type.ToLower() =="square")
                return new Square();

            return null;
        }
    }
}
