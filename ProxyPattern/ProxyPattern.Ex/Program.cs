using ProxyPattern.Ex;

namespace ProxyPattern.Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();
            browser.SendRequest();
        }
    }
}

