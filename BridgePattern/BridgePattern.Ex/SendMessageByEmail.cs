using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Ex
{
    public class SendMessageByEmail : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("This Message Send By Email : " + message);
        }
    }
}