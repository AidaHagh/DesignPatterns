namespace SingletonPatternWithProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;
            Console.WriteLine("------------Singleton-----------");
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
    }
}
