using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern.EX
{
    public interface IGalaxy
    {
        void SetBrightness(double brightness);
        void SetPosition(int x, int y);
    }
}