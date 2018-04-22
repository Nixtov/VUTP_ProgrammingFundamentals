using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();
            var numbersString = Regex.Matches(input, pattern);
            string[] matchesNumbers = numbersString.Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine("{0}", string.Join(" ", matchesNumbers));
        }
    }
}
