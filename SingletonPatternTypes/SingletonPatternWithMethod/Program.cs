using static System.Net.Mime.MediaTypeNames;

namespace SingletonPatternWithMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logger obj1=new Logger();
            // Logger obj2=new Logger();

            Console.WriteLine("------------Singleton-----------");
            Logger obj1 = Logger.GetInstance();
            Logger obj2 = Logger.GetInstance();

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());


            Console.WriteLine("------------NonSingleton-----------");
            test obj3 = new test();
            test obj4 = new test();

            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());
        }

    }
    class test
    {

    }
}
