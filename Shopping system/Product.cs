using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_system
{
    internal class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name cannot be empty");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("What product contains that many letters, please keep it belove 50 characters");
                }
                name = value;
            }
        }

        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 10000)
                {
                    throw new ArgumentException("You are actually too broke to afford this");
                }
                else if (value < 0)
                {
                    throw new ArgumentException("We do not owe you money, fix that price or else");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return $"" +
                $"Name: {name}\n" +
                $"Price: {price}\n";
        }
    }
}
