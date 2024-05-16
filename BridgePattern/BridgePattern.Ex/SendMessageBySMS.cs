using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex
{
    public class SendMessageBySMS : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("This Message Send By SMS : " + message);
        }
    }
}