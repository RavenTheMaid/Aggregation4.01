using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_system
{
    internal class Product
    {
        public Product(int id, string name, decimal price)
        {
            if (id < 10000 || id > 99999)
            {
                throw new ArgumentException("ID must be 5 digit number");
            }
            else
            {
                this.id = id;
            }
            Name = name;
            Price = price;
        }

        private readonly int id;
        public int ID
        {
            get
            {
                return id;
            }
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
                    throw new ArgumentException("you are actually too broke to afford this");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return $"" +
                $"Product Info" +
                $"ID: {id}\n" +
                $"Name: {name}\n" +
                $"Price: {price}\n";
        }










    }
}
