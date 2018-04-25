using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var index = initialValues.Last();
            var gameField = initialValues.Take(initialValues.Length - 1).ToArray();

            int steps = 0;

            while (true)
            {
                gameField = gameField.          
            }
        }
    }
}
