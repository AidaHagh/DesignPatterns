using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example1
{
    public class DarkToolbar : IToolbar
    {
        public void ShowToolbar()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Dark Toolbar ");
        }
    }
}