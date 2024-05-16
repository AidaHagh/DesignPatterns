using BridgePattern.Ex2;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IColor silver = new Silver();
            IColor black = new Black();

            AbstractDevice tv1 = new Tv(black);
            tv1.Create();
            Console.WriteLine();

            AbstractDevice tv2 = new Tv(silver);
            tv2.Create();
            Console.WriteLine();

            AbstractDevice tablet = new Tablet(silver);
            tablet.Create();


        }
    }
}