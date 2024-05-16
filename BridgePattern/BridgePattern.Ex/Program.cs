using BridgePattern.Ex;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1 Or 2 ***  1=ShortMessage,2=LongMessage");
            var type = Convert.ToInt32(Console.ReadLine());
            if (type == 1 || type == 2)
            {
                Console.WriteLine("Enter Message...");
                var message = Console.ReadLine();
                if (type == 1)
                {
                    AbstractMessage shortMessage = new ShortMessage(new SendMessageBySMS());
                    shortMessage.SendMessage(message);
                }
                else if (type == 2)
                {
                    AbstractMessage longMessage = new LongMessage(new SendMessageByEmail());
                    longMessage.SendMessage(message);
                }
            }
            else
            {
                Console.WriteLine("'"+type+"'" + " Not Valid...Just Enter 1 Or 2 ");
            }


        }
    }
}