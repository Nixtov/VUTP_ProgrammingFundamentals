using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var reslut = new List<Tuple<string, double>>();

            var grades = new List<double>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input[0];

                var digit = input.Skip(1).Select(double.Parse).ToArray();

                for (int j = 0; j < input.Length - 1; j++)
                {
                    grades.Add(digit[j]);
                }

                if (grades.Average() >= 5)
                {
                    double sum = grades.Average();

                    reslut.Add(Tuple.Create(name, sum));
                }
                grades.Clear();
            }

            reslut.Sort();


            foreach (var item in reslut.OrderBy(x => x.Item1).ThenByDescending(x => x.Item2))
            {
                Console.WriteLine("{0} -> {1:F2}", item.Item1, item.Item2);

            }
        }
    }
}
