using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.Ex
{
    public class NetWorkSetting
    {
        public IISP GetInternet()
        {
            return new InternetProxy(); 
        }
        public IISP GetISP()
        {
            return new Vodafone();
        }
    }
}