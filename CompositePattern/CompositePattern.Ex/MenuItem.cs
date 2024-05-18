using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Ex
{
    public class MenuItem : IMenuComponent
    {
        private readonly string name;
        private readonly string description;
        private readonly double price;
        private readonly bool vegetarian;

        public MenuItem(string name, string description, double price, bool vegetarian)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.vegetarian = vegetarian;
        }
        public string Name
        {
            get { return name; }
        }
        public string Description
        {
            get { return description; }
        }
        public double Price
        {
            get { return price; }
        }
        public bool IsVegetarian
        {
            get { return vegetarian; }
        }

        public string Show()
        {
            return "\t" +name+
                   "\t" + ShowIfVeg(IsVegetarian) +
                   "\t" +price+
                   "\t--" +description+"\n";
            
        }
        public string ShowIfVeg(bool isVegetrian)
        {
            if (isVegetrian)
            {
                return "V";
            }
            return "";
        }
    }
}