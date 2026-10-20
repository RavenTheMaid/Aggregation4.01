using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_system
{
    internal class ContactInfo
    {
        public ContactInfo(string mail, string phoneNumber)
        {
            Mail = mail;
            PhoneNumber = phoneNumber;
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
                else if (!value.Contains('@'))
                {
                    throw new ArgumentException("mail must contain an @");
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
                else if (!chunks[1].Contains('.'))
                {
                    throw new ArgumentException("mail must contain a period");
                }
                else if (chunks[1] == ".com" || chunks[1] == ".dk")
                {
                    throw new ArgumentException("there must be content between @ and period");
                }

                try
                {
                    periodChunk = chunks[1].Split('.');
                }
                catch
                {
                    throw new ArgumentException("Mail must have a TLD");
                }

                if (periodChunk.Length != 2)
                {
                    throw new ArgumentException("mail must contain content before and after the period");
                }
                else if (periodChunk[1] != "com" && periodChunk[1] != "dk")
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
                $"-Contact Info--\n" +
                $"Mail: {mail}\n" +
                $"Phone number: {phoneNumber}\n";
        }


    }
}
