using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> phonebook = new Dictionary<string, string>();
            //phonebook["Ivan Georgiev"] = "0989 765 843";
            //phonebook["Pesho Georgiev"] = "0989 888 843";
            //phonebook["Gosho Georgiev"] = "0989 654 843";
            //phonebook["Ivan Petrov"] = "0989 455 843";
            //phonebook.Add("Penka", "34920394-0");
            //Console.WriteLine(phonebook ["Penka"]);

            List<string> words = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
            if (!wordsCount.ContainsKey(word.ToLower()))
                {
                    wordsCount[word.ToLower()] = 0;
                }
            wordsCount
            }

        }
    }
}
