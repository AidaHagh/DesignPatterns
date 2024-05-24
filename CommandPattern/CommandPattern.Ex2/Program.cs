
namespace CommandPattern.Ex2
{
    public enum PriceAction
    {
        Increase, Decrease
    }
    class Program
    {
        static void Main(string[] args)
        {
            ModifyPrice modifyPrice = new ModifyPrice();    
            Product product1=new Product("Mobile Samsung",500);

            modifyPrice.SetCommand(new ProductCommand(product1,PriceAction.Decrease,50));
            modifyPrice.Invoke();

            modifyPrice.SetCommand(new ProductCommand(product1, PriceAction.Increase, 5));
            modifyPrice.Invoke();

            Console.WriteLine(product1);

            Console.WriteLine("*************");
            modifyPrice.Undo();
            Console.WriteLine(product1);
        }
    }
}