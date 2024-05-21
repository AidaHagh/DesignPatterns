using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.Ex
{
    public class Vodafone : IISP
    {
        public string GetResource(string site)
        {
           switch (site)
            {
                case "www.google.com":
                    return "G O O G L E";
                default:
                    return "Sorry! Not Found";
            }
        }
    }
}