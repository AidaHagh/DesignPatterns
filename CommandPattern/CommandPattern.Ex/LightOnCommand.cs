using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex
{
    public class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;    
            light.On();
            Console.ResetColor();   
        }
    }
}