using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex2
{
    public class Tv : AbstractDevice
    {
        public Tv(IColor color) : base(color)
        {
        }

        public override void Create()
        {
            Console.WriteLine("Create A Tv...");
            color.ToPaint();
        }
    }
}