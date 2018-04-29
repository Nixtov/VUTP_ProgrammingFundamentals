using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();
            string command = Console.ReadLine();
            while (true)
            {
                if (command.ToLower() == "print")
                {
                    Print(numbers);
                    break;
                }
                string[] cmdArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string cmdText = cmdArgs[0];

                switch (cmdText)
                {
                    case "push":
                        int num = int.Parse(cmdArgs[1]);
                        numbers.Add(num);
                        break;
                    case "pop":
                        if (numbers.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine(numbers.Last());
                        numbers.RemoveAt(numbers.Count - 1);
                        break;
                    case "shift":
                        if (numbers.Count < 2)
                        {
                            break;
                        }
                        int first = numbers[0];
                        numbers[0] = numbers.Last();
                        numbers[numbers.Count - 1] = first;
                        break;
                    case "addMany":
                        int insIndex = int.Parse(cmdArgs[1]);
                        if (insIndex >= 0 && insIndex < numbers.Count)
                        {
                            int[] nums = cmdArgs.Skip(2).Select(x => int.Parse(x)).ToArray();
                            numbers.InsertRange(insIndex, nums);
                        }
                        break;
                    case "remove":
                        if (numbers.Count == 0)
                        {
                            break;
                        }
                        int rmIndex = int.Parse(cmdArgs[1]);
                        if (rmIndex >= 0 && rmIndex < numbers.Count)
                        {
                            numbers.RemoveAt(rmIndex);
                        }
                        break;
                    default:
                        new Exception("handle me");
                        break;
                }
                command = Console.ReadLine();
            }
        }
        private static void Print(List<int> numbers)
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
