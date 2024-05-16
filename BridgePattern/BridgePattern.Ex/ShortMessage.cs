using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex
{
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender)
        {
            //Initialize The Super Class Variable
            sender = messageSender;
        }
        public override void SendMessage(string message)
        {
            if (message.Length <= 15)
            {
                sender.SendMessage(message);
            }
            else
            {
                Console.WriteLine("Not Sending Message ...The number of characters must be less than 15");
            }
        }
    }
}