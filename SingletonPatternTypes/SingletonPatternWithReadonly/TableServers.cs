using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternWithReadonly
{
    public class TableServers
    {
        //فقط یک نمونه ساخته میشه و هربار درخواست بشه همون نمونه فرستاده میشه
        private static readonly TableServers instance=new TableServers();  
        
        private List<string> servers = new List<string>();
        private int next = 0;
        private TableServers()
        {
            servers.Add("Ali");
            servers.Add("Roza");
            servers.Add("Hosein");
            servers.Add("Sara");
        }

        public static TableServers GetTableServers()
        {
            //با صدا زدن این متد آبجکت گرفته میشه
            return instance;    
        }

        public string NextServer()
        {
          string outPut = servers[next];
            next++;
            if (next >= servers.Count)
            {
                next = 0;   
            }
            return outPut;
        }
    }
}
//
//1 - کانستراکتور پرایوت تعریف میشه
//2-متغییر از جنس کلاس بصورت استاتیک و ریداونلی
//3-یک متد استاتیک از جنس خود کلاس تعریف میکنیم
