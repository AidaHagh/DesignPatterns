using AbstractFactoryPattern1.Example1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example1
{
    public class FactoryProvider
    {
        public static IThemeAbstractFactory GetFactory(Theme theme)
        {
            IThemeAbstractFactory themeAbstractFactory = null;

            switch (theme)
            {
                case Theme.light:
                    themeAbstractFactory = new LightThemeFactory();
                    break;
                case Theme.dark:
                    themeAbstractFactory = new DarkThemeFactory();
                    break;
            }
            return themeAbstractFactory;
        }
    }
}