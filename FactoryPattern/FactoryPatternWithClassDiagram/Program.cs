using FactoryPatternWithClassDiagram.CalculatorExample;
using FactoryPatternWithClassDiagram.CarExample;

namespace FactoryPatternWithClassDiagram
{
    class program
    {
        static void Main(string[] args)
        {
            //CarExample
            Console.WriteLine("Enter : benz | bmw | toyota\n");
            string type = Console.ReadLine();

            CarFactory factory = new CarFactory();
            ICar car1 = factory.GetCar(type);
            car1.Start();


            //CalculatorExample
            Console.WriteLine("Enter Number1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Plus | Minus | Divide | Multiple : ");
            CalculateFactory calculate = new CalculateFactory();
            ICalculate calculate1 = calculate.GetCaculation(Console.ReadLine());
            calculate1.Calculate(number1, number2);
        }
    }
}