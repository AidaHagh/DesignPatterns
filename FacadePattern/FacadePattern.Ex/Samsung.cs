using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Ex
{
    public class Samsung : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("Samsung S35");
        }

        public void Price()
        {
            Console.WriteLine("80 $");
        }
    }
}