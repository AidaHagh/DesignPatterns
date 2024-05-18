namespace CompositePattern.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            File file1 = new File("file1.txt", 1);
            File file2 = new File("file2.txt", 1);
            File file3 = new File("file3.txt", 2);
            File file4 = new File("file4.txt", 3);
            File file5 = new File("file5.txt", 3);
            File file6 = new File("file6.txt", 3);
            File file7 = new File("file7.txt", 3);

            Directory d22 = new Directory("directory22", 2);
            d22.AddData(file7);

            Directory d21 = new Directory("directory21", 2);
            d21.AddData(file5);
            d21.AddData(file6);

            Directory d2 = new Directory("directory2", 1);
            d2.AddData(d22);
            d2.AddData(d21);

            Directory d11 = new Directory("directory11", 2);
            d11.AddData(file4);

            Directory d1 = new Directory("directory1", 1);
            d1.AddData(d11);
            d1.AddData(file3);

            Directory rootDirectory = new Directory("rootDirectory", 0);
            rootDirectory.AddData(file1);
            rootDirectory.AddData(d1);
            rootDirectory.AddData(file2);
            rootDirectory.AddData(d2);

            rootDirectory.Print();

            Console.WriteLine("--------------------------");

            d11.RemoveData(file4);
            rootDirectory.Print();

            Console.WriteLine("-----------index[0]D1---------------");
            d1.GetData(0).Print();

            Console.WriteLine("-----------index[1]D21---------------");
            d21.GetData(1).Print();
           
        }
    }
}