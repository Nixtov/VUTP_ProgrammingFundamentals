using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int firstNum = 1;
            int secondNum = 1;
            int thirdNum = 1;
            for (int i = 0; i < n; i++)
            {
                thirdNum = secondNum;
                secondNum = firstNum + secondNum;
                firstNum = thirdNum;

            }
            Console.Write(firstNum + " ");
        }
    }
}
