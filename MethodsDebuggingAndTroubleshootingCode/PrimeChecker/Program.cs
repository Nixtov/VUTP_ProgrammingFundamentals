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
            string isPrime = "Prime";

            if (n < 2)
                Console.WriteLine("Not Prime");
            else
            {
                for (int i = 2; i < n; i++) // or i<= Math.Sqrt(n)
                {
                    if (n % i == 0)
                    {
                        isPrime = "Not Prime";
                        break;
                    }
                }
                Console.WriteLine(isPrime);
            }
        }
    }
}
