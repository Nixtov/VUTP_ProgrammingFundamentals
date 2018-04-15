using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();//name -> phonenumber
            string command = Console.ReadLine();

            while (command != "END")
            {
                var argms = command.Split(' ').ToArray();

                switch (argms [0])
                {
                    default:
                    case "A":
                        phonebook[argms[1]] = argms[2];
                        break;
                    case "S":
                        if (phonebook.ContainsKey(argms[1]))
                        {
                            Console.WriteLine($"Contact {argms[1]} does not exist");
                        }
                        break;
                    case "ListAll":
                        foreach (var contact in collection)
                        {

                        }
                }
            }
        }
    }
}
