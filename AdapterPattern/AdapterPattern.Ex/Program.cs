using AdapterPattern.Ex;
using MovableClassLibrary;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable bugattiVeyron = new BugattiVeyron();
            MovableAdapter movableAdapter =new MovableAdapter(bugattiVeyron);
            Console.WriteLine("bugattiVeyron top speed is : " + movableAdapter.GetSpeed()+ " kmph ");

        }
    }

}

//در اینجا به عنوان مثال کتابخانه ای که بهش دسترسی داریم سرعت ماشین هارو براساس مایل نشون میده
//و ما میخواهیم برحسب کیلومتر باشه پس با استفاده از الگوی آداپتر این کار رو انجام میدیم 
//کلاس آداپتر اطلاعات رو از آن کتابخانه میگیره و به شکلی که ما نیاز داریم بهمون میده