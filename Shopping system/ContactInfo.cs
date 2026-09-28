using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_system
{
    internal class ContactInfo
    {
        public ContactInfo(int id, string mail, string phoneNumber)
        {
            ID = id;
            Mail = mail;
            PhoneNumber = phoneNumber;
        }

        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("ID must be 5 digit number");
                }
                id = value;
            }
        }
        private string? mail;
        public string? Mail
        {
            get
            {
                return mail;
            }
            set
            {
                string[] chunks;
                string[] periodChunk;

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Mail cannot be empty");
                }
                
                try
                {
                    chunks = value.Split('@');
                }
                catch
                {
                    throw new ArgumentException("mail must contain an @");
                }

                if (chunks.Length != 2)
                {
                    throw new ArgumentException("mail must contain content before and after @");
                }

                try
                {
                    periodChunk = chunks[1].Split('.');
                }
                catch
                {
                    throw new ArgumentException("Mail must have a TLD");
                }

                if (periodChunk[1] != "com" && periodChunk[1] != "dk")
                {
                    throw new ArgumentException("TLD must be either .com or .dk");
                }

                mail = value;
            }
        }
        private string? phoneNumber;
        public string? PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (!value!.Any(char.IsDigit))
                {
                    throw new ArgumentException("phone number has to be... numbers..");
                }
                else if (value!.Length != 8)
                {
                    throw new ArgumentException("Phone number must be 8 digits long");
                }

                phoneNumber = value;
            }
        }
        public override string ToString()
        {
            return $"" +
                $"Contact ID: {id}\n" +
                $"Mail: {mail}\n" +
                $"Phone number: {phoneNumber}";
        }


    }
}
