using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int middleStart = sequence.Length / 4;
            int middleEnd = middleStart + sequence.Length / 2;
            int summing = middleStart - 1;
            for (int i = middleStart; i < middleEnd; i++)
            {
                int sum = sequence[i] + sequence[summing];
                Console.Write($"{sum} ");
                summing--;
                if (summing < 0)
                {
                    summing = sequence.Length - 1;
                }
            }
        }
    }
}
