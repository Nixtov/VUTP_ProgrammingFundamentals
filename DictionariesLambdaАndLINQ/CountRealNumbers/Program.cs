using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Dictionary<double, int> occurrences = new Dictionary<double, int>;

            foreach (var number in inputNumbers)
            {
                if (!occurrences.ContainsKey(number))
                {
                    if (!occurrences.ContainsKey(number))
                    
                        [number] = 0;
                    occurrences[number] = occurrences[number] + 1;
            }
                foreach (KeyValuePair<double, int> numberAndCount in occurrences)
                {
                    Console.WriteLine($"{numberAndCount.Key}->{numberAndCount.Value}");
                }
        }
    }
}
