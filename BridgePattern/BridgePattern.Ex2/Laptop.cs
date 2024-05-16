using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex2
{
    public class Laptop : AbstractDevice
    {
        public Laptop(IColor color):base(color) 
        {
            
        }
        public override void Create()
        {
            Console.WriteLine("Create A Laptop...");
            color.ToPaint();
        }
    }
}