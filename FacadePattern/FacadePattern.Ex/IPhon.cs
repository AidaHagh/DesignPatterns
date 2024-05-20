using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Ex
{
    public class IPhon : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("IPhon 15");
        }

        public void Price()
        {
            Console.WriteLine("100 $");
        }
    }
}