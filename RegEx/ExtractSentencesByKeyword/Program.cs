using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string matchWord = Console.ReadLine();

            string input = Console.ReadLine();

            string[] sentences = input.Split('!', '.', '?');

            List<string> resList = new List<string>();

            foreach (var sentence in sentences)
            {
                Regex regex = new Regex("\\W+" + matchWord + "\\W+");

                if (regex.IsMatch(sentence))
                {
                    resList.Add(sentence.Trim());
                }
            }
            Console.WriteLine(string.Join("\n", resList));
        }
    }
}
