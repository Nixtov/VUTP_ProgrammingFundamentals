using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersAtOddPositions2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] array = new int[splitInput.Length];

            InitializeArray(splitInput, array);
            CountOddNumbersAtOddPositions(array);
        }

        static void InitializeArray(string[] splitInput, int[] array)
        {
            for (int i = 0; i < splitInput.Length; i++)
            {
                array[i] = int.Parse(splitInput[i]);
            }
        }

        static void CountOddNumbersAtOddPositions(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2 == 1 || array[i] % 2 == -1) && i % 2 == 1)
                {
                    Console.WriteLine("Index {0} -> {1}", i, array[i]);
                }
            }
        }
    }
}
