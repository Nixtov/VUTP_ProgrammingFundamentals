using System;
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
            var input = Console.ReadLine().Split().Select(Int64.Parse).ToList();

            Int64 bases = input[0];
            Int64 number = input[1];

            List<Int64> solution = new List<Int64>();

            while (number > 0)
            {
                Int64 remainder = number % bases;
                solution.Add(remainder);
                number /= bases;
            }
            solution.Reverse();
            Console.WriteLine(string.Join("", solution));
        }
    }
}
