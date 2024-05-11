using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example1
{
    public class LightThemeFactory : IThemeAbstractFactory
    {
        public IDialog GetDialog()
        {
            IDialog lightDialog = new LightDialog();
            return lightDialog;
        }

        public IToolbar GetToolbar()
        {
            IToolbar lightToolbar = new LightToolbar();
            return lightToolbar;
        }
    }
}