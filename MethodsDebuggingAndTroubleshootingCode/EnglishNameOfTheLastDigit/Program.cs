using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            LastDigit(num);

        }
        static void LastDigit(string number)
        {
            char LastNumber = number[number.Length - 1];
            switch (LastNumber)
            {
                case '0': Console.WriteLine("zero");break;
                case '1': Console.WriteLine("one");break;
                case '0': Console.WriteLine("zero");break;
                case '0': Console.WriteLine("zero");break;
                case '0': Console.WriteLine("zero");break;
                case '0': Console.WriteLine("zero");break;
            }
        }
    }
}
