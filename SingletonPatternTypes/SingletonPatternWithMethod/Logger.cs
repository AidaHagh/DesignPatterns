using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternWithMethod
{
    public class Logger
    {
        //متغییر از جنس کلاس بصورت استاتیک  
        private static Logger logger;

        //کانستراکتور پرایوت تعریف میشه
        private Logger()
        {

        }

        //یک متد استاتیک از جنس خود کلاس تعریف میکنیم
        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }
    }
}



//برای صدا زدن یک متد باید از کلاس آبجکت بگیریم برای اینکه لازم به گرفتن آبجکت نباشه 
// متد رو استاتیک میکینم