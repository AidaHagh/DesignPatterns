namespace FactoryPatternWithClassDiagram
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter : benz | bmw | toyota\n");
            string type=Console.ReadLine();

            CarFactory factory = new CarFactory();  
            ICar car1= factory.GetCar(type);
            car1.Start();

        }
    }
}