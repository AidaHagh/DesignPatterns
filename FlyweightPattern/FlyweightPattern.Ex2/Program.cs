namespace FlyweightPattern.Ex2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Draw Red Color Circle...");
         
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Red");
                circle.Draw();  
            }
            Console.ResetColor();   

            Console.WriteLine("Draw Blue Color Circle...");
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Blue");
                circle.Draw();
            }
            Console.ResetColor();

            Console.WriteLine("Draw Green Color Circle...");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Green");
                circle.Draw();
            }
            Console.ResetColor();

            Console.WriteLine("*************");
            Console.WriteLine("How many circles are made?");
            Console.WriteLine(ShapeFactory.GetCount());
        }
    }
}