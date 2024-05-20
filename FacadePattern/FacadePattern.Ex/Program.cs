namespace FacadePattern.Ex
{
    class Program
    {
        private static int choice;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("-------- Wellcome Mobile Shop ----------- \n");
                Console.WriteLine("-------- 1.IPhon ----------- \n");
                Console.WriteLine("-------- 2.Samsung ----------- \n");
                Console.WriteLine("-------- 3.Motorola ----------- \n");
                Console.WriteLine("-------- 4.Exit ----------- \n");
                Console.WriteLine("Enter Number Of Your Choice....");

                 choice = Convert.ToInt32(Console.ReadLine());
                ShopKeeper shopKeeper = new ShopKeeper();
                switch (choice)
                {
                    case 1:
                        {
                            shopKeeper.IPhonSale();
                        }
                        break;
                    case 2:
                        {
                            shopKeeper.SamsungSale();
                        }
                        break;
                    case 3:
                        {
                            shopKeeper.MotorolaSale();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("nothing....");
                        }
                        return;

                }
            }
            while (choice!=4);
        }
    }
}// درجاهایی که ساب سیستم های زیادی داریم و پیچیدگی های زیادی داره
 //برای اینکه بتونیم از انها استفاده کنیم از این الگو استفاده میکنیم
 //و کارو برای کلاینت اسان میکنیم