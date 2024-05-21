using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern.EX
{
    public class Ellipse
    {
        private readonly int width;
        private readonly int height;
        private readonly string color;

        public Ellipse(int width, int height, string color)
        {
            this.width = width;
            this.height = height;
            this.color = color;
        }

        public override string ToString()
        {
            return string.Format($"width:{width}, height:{height}, color:{color}");
        }
    }
}