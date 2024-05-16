using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex2
{
    public class Silver : IColor
    {
        public void ToPaint()
        {
            Console.WriteLine("Paint Silver....");
        }
    }
}