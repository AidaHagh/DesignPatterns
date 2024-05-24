using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace ChainOfResponsibilityPattern.Ex
{
    //سفارش خرید
    public class PurchaseOrder
    {
        public PurchaseOrder(int requestNumber, double amount, double price, string name)
        {
            RequestNumber = requestNumber;
            Amount = amount;
            Price = price;
            Name = name;
            Console.WriteLine("****----------****");
            Console.WriteLine($"purchase request for {name} amount of :{amount}," +
                $"price of:{price.ToString()}$ , has been submitted. ");
        }

        public int RequestNumber { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        
    }
}