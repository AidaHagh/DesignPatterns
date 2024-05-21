using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern.Ex
{
    public class Browser
    {
        //send a request ti ISP
        public void SendRequest()
        {
            Console.WriteLine("Enter Site URL...");
            string site=Console.ReadLine();
            string response=GetInternetProvider().GetResource(site);
            LoadResponse(response); 
        }
        //print the output from ISP
        public void LoadResponse(string response) 
        {
            Console.WriteLine(response);
        }
        //get the network setting for isp to use
        public IISP GetInternetProvider() 
        {
            return new NetWorkSetting().GetInternet();
        }
    }
}