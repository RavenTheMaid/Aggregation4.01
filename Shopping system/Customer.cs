using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_system
{
    internal class Customer
    {
        public Customer(string name, ContactInfo contactInfo, string subscription)
        {
            CustomerName = name;
            ContactInformation = contactInfo;
            Subscription = subscription;
            
        }
        public Customer(string name, ContactInfo contactInfo, string subscription, Basket basket)
            :this(name, contactInfo, subscription)
        {
            Basket = basket;
        }

        private string subscription;
        public string Subscription
        {
            get
            {
                return subscription;
            }
            set
            {
                if (value.ToLower() != "basic" && value.ToLower() != "premium" && value.ToLower() != "gold")
                {
                    throw new ArgumentException("Customer must be either basic, preium or gold");
                }
                subscription = value;
            }
        }


        private string supplierName;
        public string CustomerName
        {
            get
            {
                return supplierName;
            }
            set
            {
                //to let the name be allowed inside all areas
                string firstName = "";
                string lastName = "";
                //checks if name is null
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Suppliers name cannot be empty");
                }

                //i have decided the teacher is only allowed to have a first and last name
                //so this makes sure that there are no more then 3 chunks, as each chunk represents a part of the name
                string[] chunks = value.Split(' ');
                if (chunks.Length != 2)
                {
                    throw new ArgumentException("Supplier cannot have more then a first and lastname because i say so");
                }

                //makes sure the teacher actually has a first name
                try
                {
                    firstName = chunks[0];
                }
                catch
                {
                    throw new ArgumentException("Supplier must have a first name");
                }

                //checks first name for digits
                if (firstName.Any(char.IsDigit))
                {
                    throw new ArgumentException("First name cannot contain numbers");
                }

                //makes sure the supplier has a first name
                try
                {
                    lastName = chunks[1];
                }
                catch
                {
                    throw new ArgumentException("Supplier must have a last name");
                }

                //checks for digits
                if (lastName.Any(char.IsDigit))
                {
                    throw new ArgumentException("Last name cannot contain numbers");
                }

                supplierName = value;
                {


                }
            }
        }
        private ContactInfo contactInformation;
        public ContactInfo ContactInformation
        {
            get
            {
                return contactInformation;
            }
            set
            {
                contactInformation = value;
            }
        }
        private Basket basket;
        public Basket Basket
        {
            get
            {
                return basket;
            }
            set
            {
                basket = value;
            }
        }
        
        public override string ToString()
        {
            if (Basket == null)
            {
                return $"" +
                $"--Supplier Info--\n" +
                $"Name: {supplierName}\n\n" +
                $"{contactInformation.ToString()}";
            }
            else
            {
                return $"" +
                $"--Supplier Info--\n" +
                $"Name: {supplierName}\n\n" +
                $"{contactInformation.ToString()}" +
                $"{Basket.ToString()}";
            }
            
        }
    }
}
