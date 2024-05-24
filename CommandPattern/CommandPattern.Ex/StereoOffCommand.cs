using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex
{
    public class StereoOffCommand : ICommand
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }
    }
}