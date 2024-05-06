

namespace SingletonPatternWithReadonly
{
    class Program
    {
        static TableServers hostList1 = TableServers.GetTableServers();
        static TableServers hostList2 = TableServers.GetTableServers();
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                Host1GetNextServer();
                Host2GetNextServer();
            }
            Console.WriteLine(hostList1.GetHashCode());
            Console.WriteLine(hostList2.GetHashCode());
        }
        private static void Host1GetNextServer()
        {
            Console.WriteLine("The Next Server Is: " + hostList1.NextServer());

        }
        private static void Host2GetNextServer()
        {
            Console.WriteLine("The Next Server Is: " + hostList2.NextServer());

        }
    }
}