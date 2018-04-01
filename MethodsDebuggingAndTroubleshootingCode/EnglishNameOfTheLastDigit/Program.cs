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
                case '0': Console.WriteLine("zero"); break;
                case '1': Console.WriteLine("one"); break;
                case '2': Console.WriteLine("two"); break;
                case '3': Console.WriteLine("three"); break;
                case '4': Console.WriteLine("four"); break;
                case '5': Console.WriteLine("five"); break;
                case '6': Console.WriteLine("six"); break;
                case '7': Console.WriteLine("sevet"); break;
                case '8': Console.WriteLine("eigth"); break;
                case '9': Console.WriteLine("nine"); break;
            }
        }
    }
}
