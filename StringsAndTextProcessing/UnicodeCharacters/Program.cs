using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (var c in input)
            {
                sb.Append("\\u00");
                string hx = Convert.ToString(c, 16);
                sb.Append(hx);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
