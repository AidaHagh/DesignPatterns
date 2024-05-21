using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.Ex
{
    public class InternetProxy : IISP
    {
        public string GetResource(string site)
        {
            LogRequest(site);
            if (IsBlocked(site))
            {
                return "This Site Is Blocked as per compony policy";
            }
            NetWorkSetting setting = new NetWorkSetting();
            return setting.GetISP().GetResource(site);
        }

        public void LogRequest(string site)
        {
            Console.WriteLine(DateTime.Now + "request for : "+site);
        }

        public bool IsBlocked(string site)
        {
            switch (site)
            {
                case "www.google.com":
                    return false;
                case "www.Microsoft.com":
                    return true;
                default:
                    return true;


            }

        }
    }
}