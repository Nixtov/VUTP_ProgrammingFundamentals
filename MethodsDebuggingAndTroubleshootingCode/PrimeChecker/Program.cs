using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IsPrime(n);
        }

        private static void IsPrime(int n)
        {
            string isPrime = "True";
            if (n < 2)
                Console.WriteLine("False");
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = "False";
                        //break;
                    }
                }
                Console.WriteLine(isPrime);
            }
        }
    }
}
