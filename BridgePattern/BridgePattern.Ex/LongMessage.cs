using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSender)
        {
            //Initialize The Super Class Variable
            sender = messageSender; 
        }
        public override void SendMessage(string message)
        {
            sender.SendMessage(message);
        }
    }
}