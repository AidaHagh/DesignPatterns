using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex
{
    public class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            light.Off();
            Console.ResetColor();
        }
    }
}