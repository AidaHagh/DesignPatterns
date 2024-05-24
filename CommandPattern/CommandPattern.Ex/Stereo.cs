using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex
{
    public class Stereo
    {
        public void Off()
        {
            Console.WriteLine("Stereo is Off....");
        }

        public void On()
        {
            Console.WriteLine("Stereo is On....");
        }

        public void SetCD()
        {
            Console.WriteLine("Stereo is set for CD input....");
        }

        public void SetDVD()
        {
            Console.WriteLine("Stereo is set for DVD input....");
        }

        public void SetRadio()
        {
            Console.WriteLine("Stereo is set for Radio....");

        }

        public void SetVolume(int volume)
        {
            // code to set the volume
            Console.WriteLine("Stereo volume set to " + volume);

        }
    }
}