using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secomdNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int check1 = GetMax (firstNum, secomdNum);
            int check2 = GetMax(check1, thirdNum);
            Console.WriteLine(check2);

        }
        static int GetMax(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            return b;
        }
    }
}
