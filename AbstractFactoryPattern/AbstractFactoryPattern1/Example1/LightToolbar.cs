using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example1
{
    public class LightToolbar : IToolbar
    {
        public void ShowToolbar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Light Toolbar ");
        }
    }
}