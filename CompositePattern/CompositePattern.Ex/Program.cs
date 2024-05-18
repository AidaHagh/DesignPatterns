using CompositePattern.Ex;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Burgers","Description Burgers....");
            menu.Add(new MenuItem("Chicken Burger", "Description Chicken Burger....", 150000, false));
            menu.Add(new MenuItem("Cheese Burger", "Description Cheese Burger....", 120000, false));

            menu.Add(new Menu("Vegetarian Dishes", "Description Vegetarian Dishes...."));
            menu.Add(new MenuItem("Pasta Salad", "Description Pasta Salad....", 50000, true));
            menu.Add(new MenuItem("Pepper Potatoes", "Description Pepper Potatoes....", 30000, true));
            menu.Add(new MenuItem("Lettuce salad", "Description Lettuce salad....", 20000, true));

            Console.WriteLine(menu.Show());
        }
    }
}