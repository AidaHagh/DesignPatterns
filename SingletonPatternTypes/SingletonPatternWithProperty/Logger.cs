using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternWithProperty
{
    public class Logger
    {
        //متغییر از جنس کلاس بصورت استاتیک
        private static Logger instance;

        //کانستراکتور پرایوت تعریف میشه
        private Logger()
        {

        }
        //پراپرتی از جنس کلاس و استاتیک که فقط get داره
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }

        }
    }
}
