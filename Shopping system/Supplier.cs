using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_system
{
    internal class Supplier
    {
        public Supplier(int id, string name)
        {
            if (id < 10000 || id > 99999)
            {
                throw new ArgumentException("ID must be 5 digit number");
            }
            else
            {
                this.id = id;
            }
            SupplierName = name;
        }
        public Supplier(int id, string name, ContactInfo contactInfo)
            :this(id, name)
        {
            ContactInformation = contactInfo;
        }


        private readonly int id;
        public int ID
        {
            get
            {
                return id;
            }
        }
        private string supplierName;
        public string SupplierName
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
        public override string ToString()
        {
            return $"" +
                $"ID: {id}\n" +
                $"Name: {supplierName}\n" +
                $"ContactInfo:\n{contactInformation.ToString()}";
        }
    }
}
