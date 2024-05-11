using BuilderPattern.Ex1;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Concrete House-----------");
            IHouseBuilder concreteHouse = new ConcreteHouseBuilder();
            ConstructionEngineer Engineer1 = new ConstructionEngineer(concreteHouse);
            House house1 = Engineer1.ConstructHouse();
            Console.WriteLine("House Is : "+ house1);

            Console.WriteLine("----------Prefabricated House-----------");
            IHouseBuilder PrefabricatedHouse=new PreFabricatedHouseBuilder();   
            ConstructionEngineer engineer2=new ConstructionEngineer(PrefabricatedHouse);
            House house2= engineer2.ConstructHouse();
            Console.WriteLine("House Is : " + house2);
        }
    }
}
