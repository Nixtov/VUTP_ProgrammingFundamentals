using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;

            inputNumbers.Sort();

            for (int i = 1; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == inputNumbers[i - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(inputNumbers[i - 1] + " => " + count);
                    count = 1;
                }
            }
        }
    }
}
