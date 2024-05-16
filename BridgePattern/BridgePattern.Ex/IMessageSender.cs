using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
}