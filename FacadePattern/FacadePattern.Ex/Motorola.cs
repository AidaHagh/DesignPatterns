using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Ex
{
    public class Motorola : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("Motorola Edge");
        }

        public void Price()
        {
            Console.WriteLine("30 $");
        }
    }
}