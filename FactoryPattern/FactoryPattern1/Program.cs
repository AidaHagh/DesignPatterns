﻿namespace FactoryPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter : Rectangle |circle |Square");


            ShapeFactory factory = new ShapeFactory();
            IShape shape1= factory.GetShape(Console.ReadLine());
            shape1.Draw();
        }
    }
}

//وقتی چند کلاس باهم عملکرد مشابهی دارند در واقع متد یکسانی دارند
//از اینترفیس استفاده میکنیم و همه آن کلاس ها از این اینتر فیس ارث بری میکننند
//تا اینجا مربوط به شی گرایی است وقتی میخواهیم از این کلاسها با توجه به نیاز
//در جاهای مختلف استفاده کنیم یا تغییراتی در آنها ایجاد کنیم
//با مشکل مواجه میشویم مثلا میخوایم یک مورد دیگه اضافه کنیم باید بریم
//در همه جا که از این کلاس ها استفاده شده تغییرات رو اعمال کنیم
//پس در توسعه پروژه با مشکل مواجه میشیم پس دراینجاست که پای فکتوری پترن میادوسط
//میاییم و یک کلاس مشترک از جنس اینترفیس خودآنها برای این کلاس ها درست میکنیم 
//و نمونه سازی از این کلاسها را به آن کلاس مشترک میسپاریم
//وهر تغییری که نیاز باشه فقط در آن کلاس مشترک اعمال میکینم 