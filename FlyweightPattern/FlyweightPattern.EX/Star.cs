using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern.EX
{
    public class Star : IGalaxy
    {
        public static Ellipse starShape = new Ellipse(10, 5, "blue");//Intrinsic states
        // there are Extrinsic states

        int positionX;
        int positionY;
        double brightness;


        public void SetBrightness(double brightness)
        {
           this.brightness = brightness;
        }

        public void SetPosition(int x,int y)
        {
            this.positionX = x;
            this.positionY = y;
        }

        public override string ToString()
        {
            return string.Format($"A Star at located at [{positionX},{positionY}] coordinate and is having a brightness of [{brightness}]% and [{Star.starShape}]\n");
        }
    }
}