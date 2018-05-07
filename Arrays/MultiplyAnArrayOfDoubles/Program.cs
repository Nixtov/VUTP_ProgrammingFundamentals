using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());

            foreach (var digit in array)
            {
                Console.Write(digit * number + " ");
            }
        }
    }
}
