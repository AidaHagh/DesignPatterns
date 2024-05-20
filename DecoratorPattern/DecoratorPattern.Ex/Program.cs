namespace DecoratorPattern.Ex 
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new DeCof();
            Console.Write(beverage1.Description+"-");
            Console.WriteLine(" "+beverage1.Cost() + " Toman");

            Beverage beverage2 = new CoconutMilk(new Chocolate(new Espresso()));
            Console.Write(beverage2.Description + "-");
            Console.WriteLine(" " + beverage2.Cost()+ " Toman");

            Beverage beverage3 = new SteamedMilk(new Chocolate(new Chocolate(new Espresso())));
            Console.Write(beverage3.Description + "-");
            Console.WriteLine(" " + beverage3.Cost() + " Toman");
        }
    }
}