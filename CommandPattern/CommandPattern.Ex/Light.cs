using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on....");
        }

        public void Off()
        {
            Console.WriteLine("Light is off....");
        }
    }
}