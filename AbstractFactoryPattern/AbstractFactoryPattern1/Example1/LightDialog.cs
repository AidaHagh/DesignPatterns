using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern1.Example1
{
    public class LightDialog : IDialog
    {
        public void ShowDialog()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Light dialog ");
        }
    }
}