using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double totalCounter = 0;
            for (int i = 0; i < n; i++)
            {
                string[] regPar = Console.ReadLine().Split();
                int raindropsCount = int.Parse(regPar [0]);
                int sqMet = int.Parse(regPar [1]);
                totalCounter = totalCounter + (raindropsCount / sqMet);
            }

            Console.WriteLine(totalCounter);
        }

    }
}
