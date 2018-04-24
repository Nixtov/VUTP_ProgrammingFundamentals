using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_NtoBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64[] input = Console.ReadLine().Split(' ').Select(Int64.Parse).ToArray();
            Int64 baseN = input[0];
            Int64 number = input[1];
            Int64 pow = 0;
            Int64 result = 0;

            while (number > 0)
            {
                Int64 digit = number % 10;
                Int64 baseNRaisedToPower = 1;

                if (pow == 0)
                {
                    baseNRaisedToPower = 1;
                }
                else
                {
                    for (Int64 i = 0; i < pow; i++)
                    {
                        baseNRaisedToPower *= baseN;
                    }
                }

                result += digit * baseNRaisedToPower;
                pow++;
                number = number / 10;
            }
            Console.WriteLine(result);
        }
    }
}
