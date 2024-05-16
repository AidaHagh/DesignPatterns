using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex2
{
    public abstract class AbstractDevice
    {
        protected IColor color;

        protected AbstractDevice(IColor color)
        {
            this.color = color;
        }
        public abstract void Create();
    }
}