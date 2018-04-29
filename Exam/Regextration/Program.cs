using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regextration
{
    class Program
    {
        static void Main(string[] args)
        {
            string contact = Console.ReadLine();
            while (true)
            {
                if (contact.ToLower() == "end")
                {
                    break;
                }
                string [] arguments = contact.Split(new char[] { '|' });
                string userName = arguments[0];
                string emailAddress = arguments[1];
                string phoneNumber = arguments[2];
                bool validateUserName = UsernameValid(userName);
                bool validateEmailAddress = EmailValid(emailAddress);
                bool validatePhoneNumber = PhoneNumberValid(phoneNumber);

                if (validateUserName && validateEmailAddress && validatePhoneNumber)
                {
                    Console.WriteLine("Regextration successful!");
                }
                contact = Console.ReadLine();
            }
        }
        public static bool UsernameValid(string username)
        {
            bool startsWithCapitalLetter = char.IsUpper(username[0]);

            if (startsWithCapitalLetter)
            {
                for (int i = 1; i < username.Length; i++)
                {
                    if (char.IsDigit(username[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool EmailValid(string email)
        {
            string pattern = @"(^[a-zA-Z]{4,}@[\w]{3,}\.bg$)|(^[a-zA-Z]{4,}@[\w]{3,}\.net$)|(^[a-zA-Z]{4,}@[\w]{3,}\.com$)";
            Regex rgx = new Regex(pattern);

            return rgx.IsMatch(email);
        }
        public static bool PhoneNumberValid(string phoneNumber)
        {
            string pattern = @"(\+359[\-]{1}[\d]{1}[\-]{1}[\d]{3}[\-]{1}[\d]{4})|(\+359[\-]{1}[\d]{1}[\-]{1}[\d]{3}[\-]{1}[\d]{4})";
            Regex rgx = new Regex(pattern);
            return rgx.IsMatch(phoneNumber);
        }
    }
}
