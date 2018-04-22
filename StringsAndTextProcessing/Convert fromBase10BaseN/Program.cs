﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_fromBase10BaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger baseN = numbers[0];
            BigInteger number = numbers[1];
            string result = string.Empty;

            while (number > 0)
            {
                BigInteger lastDigit = number % baseN;
                number = number / baseN;
                result += lastDigit.ToString();
            }
            Console.WriteLine(string.Join("", result.Reverse()));
        }
    }
}
