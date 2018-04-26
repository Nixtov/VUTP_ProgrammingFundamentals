
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resoursesAndQuantities = new Dictionary<string, long>();

            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());

                if (!resoursesAndQuantities.ContainsKey(resourse)) // ako не съдържа add resourse with quantity = 0;
                {
                    resoursesAndQuantities.Add(resourse, 0);
                }
                resoursesAndQuantities[resourse] += quantity;
            }
            foreach (var key in resoursesAndQuantities)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }
        }
    }
}
