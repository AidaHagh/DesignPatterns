using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex
{
    public class StereoOnWithCdCommand : ICommand
    {
        Stereo _stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(12);
            Console.ResetColor();

        }
    }
}