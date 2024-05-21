using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern.EX
{
    public class Planet : IGalaxy
    {
        public static Ellipse planetShape = new Ellipse(30,20, "red");//Intrinsic states
        // there are Extrinsic states

        int positionX;
        int positionY;
        double brightness;


        public void SetBrightness(double brightness)
        {
            this.brightness = brightness;
        }

        public void SetPosition(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }

        public override string ToString()
        {
            return string.Format($"A Planet at located at [{positionX},{positionY}] coordinate and is having a brightness of [{brightness}]% and [{Planet.planetShape}]\n");
        }
    }
}