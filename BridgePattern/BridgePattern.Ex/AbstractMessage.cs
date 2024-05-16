using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex
{
    public abstract class AbstractMessage 
    {
        protected IMessageSender sender;

        public abstract void SendMessage(string message);
    }
}