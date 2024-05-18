namespace CompositePattern.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer1 = new Developer(200,"Aida", "Pro Developer");
            Developer developer2 = new Developer(201,"Nazi","Developer");

            CompanyDirectory engDirectory = new CompanyDirectory();
            engDirectory.Add(developer1);
            engDirectory.Add(developer2);

            Manager manager1 = new Manager(".Net Programmer", "Aida", 200);
            Manager manager2 = new Manager("Seo", "Sara", 202);

            CompanyDirectory accDirectory = new CompanyDirectory();
            accDirectory.Add(manager1);
            accDirectory.Add(manager2);

            CompanyDirectory directory= new CompanyDirectory();
            directory.Add(engDirectory);
            directory.Add(accDirectory);
            directory.ShowEmployeeDetails();

        }
    }
}