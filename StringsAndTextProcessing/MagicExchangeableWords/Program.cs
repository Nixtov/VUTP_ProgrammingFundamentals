using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            string string1 = input[0];
            string string2 = input[1];
            HashSet<char> set = new HashSet<char>();

            var set1 = new HashSet<char>();
            var set2 = new HashSet<char>();

            foreach (var c in string2)
            {
                set2.Add(c);
            }
        }
    }
}
