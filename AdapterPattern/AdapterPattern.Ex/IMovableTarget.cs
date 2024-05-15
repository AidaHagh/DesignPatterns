using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Ex
{
    public interface IMovableTarget
    {
        //return speed in KMPH
        double GetSpeed();
    }
}