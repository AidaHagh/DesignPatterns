using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example2
{
    public class ArtChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("SitOn:ArtChair");
        }
    }
}