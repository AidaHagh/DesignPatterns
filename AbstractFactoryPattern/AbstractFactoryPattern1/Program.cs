using AbstractFactoryPattern1.Example1;
using AbstractFactoryPattern1.Example1.Enum;
using AbstractFactoryPattern1.Example2;
using AbstractFactoryPattern1.Example2.Enum;

namespace AbstractFactoryPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            IThemeAbstractFactory themeAbstractFactory = FactoryProvider.GetFactory(Theme.light);

            IToolbar toolbar = themeAbstractFactory.GetToolbar();
            toolbar.ShowToolbar();

            IDialog dialog = themeAbstractFactory.GetDialog();
            dialog.ShowDialog();

            // Console.ReadLine();

            //ex2
            IFurnitureAbstractFactory furnitureAbstractFactory = FactoryProvider2.GetFactory(FurnitureType.Art);
            ICoffeeTable table1 = furnitureAbstractFactory.CreateCoffeeTable();
            table1.DrinkCoffee();

            ISofa sofa1 = furnitureAbstractFactory.CreateSofa();
            sofa1.SitOn();
        }

    }
}