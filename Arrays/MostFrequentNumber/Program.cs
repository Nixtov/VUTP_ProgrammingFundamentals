using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentNumber = 0;
            int counter = 1;
            int maxCounter = 0;
            int maxNumber = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                currentNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == currentNumber)
                    {
                        counter++;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxNumber = currentNumber;
                }

                counter = 1;
            }

            Console.WriteLine($"{maxNumber}");

        }
    }
}
