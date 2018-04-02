using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split (' ').ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                Swap (input, i, input.Length -1 -i)
            }
        }
        private static void Swap (string [] input, int i, int v)
        {
            string temp = input[i];
            input[i] = input[v];
            input[v] = temp;
        }
    }
}
