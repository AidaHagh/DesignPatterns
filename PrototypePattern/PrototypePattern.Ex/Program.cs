using PrototypePattern.Ex;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company();
            company1.CompanyName = "Company 1";
            company1.LoadData();
            //Console.WriteLine(company1);

            Company company2 = (Company) company1.Clone();
            company2.CompanyName = "Company 2";
            company2.Employees[2].EmployeeName = "Change Employee3";
            //company2.LoadData();
            Console.WriteLine(company1);
            Console.WriteLine(company2);
        }
    }
}
//کارمندان شرکت اول در شعبه دوم شرکت هم فعالیت دارند
//و میخواهیم همان نفرات باشن ودیگه از دیتا فراخوانی نکنیم از کلون استفاده میکنیم 
// با تغییر در کارمندسوم در شرکت دوم همان تغییر در شرکت اول هم صورت میپذیرد shallow copy در
//ولی در DeepCopy  تغییر فقط درهرکدام از شعبه ها که صورت گرفته انجام میپذیرد

//به طور کلی میشه گفت در دیپ کپی فضای مجزا برای ذخیره اطلاعات برای کلاس امپلوی وجود داره
//و در شلو کپی یک فضا وجود داره به خاطر همین با تغییر یکی اون یکی هم تغییر میکنه