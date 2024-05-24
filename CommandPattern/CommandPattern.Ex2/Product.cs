using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Ex2
{
    public class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }

        //برای افزایش مالیات
        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"Increase {amount} for {Name} ");

        }

        //برای اعمال تخفیف
        public bool DecreasePrice(int amount)
        {
            if (amount < Price)
            {
                Price -= amount;
                Console.WriteLine($"Decrease {amount} for {Name} ");
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"current price for {Name} product is {Price}$";
        }

    }
}