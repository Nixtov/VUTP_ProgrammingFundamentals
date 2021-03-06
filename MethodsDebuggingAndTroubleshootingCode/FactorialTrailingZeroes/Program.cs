﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main()
        {

            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = GetFactorial(n);
            Console.WriteLine(GetTrailingZeroes(fact));
        }

        static BigInteger GetFactorial(BigInteger n)
        {
            BigInteger fact = 1;

            do
            {
                fact = fact * n;
                n--;
            } while (n > 1);

            return fact;
        }

        static BigInteger GetTrailingZeroes(BigInteger num)
        {
            BigInteger timesZero = 0;
            while (num % 10 == 0)
            {
                num = num / 10;
                timesZero++;
            }
            return timesZero;
        }
    }
}

