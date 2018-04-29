using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristDestinations
{
    class Program
    {
        private static Dictionary<string, List<string>> destinations = new Dictionary<string, List<string>>();
        static void Main()
        {
            string inputData = Console.ReadLine();
            while (true)
            {
                if (inputData.ToLower() == "end")
                {
                    break;
                }
                string[] arguments = inputData
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (arguments[0].ToLower() == "add")
                {
                    string country = arguments[1];
                    string city = arguments[2];
                    bool cityData = CityDatabase(city);
                    if (!cityData)
                    {
                        if (!destinations.ContainsKey(country))
                        {
                            destinations.Add(country, new List<string>());
                        }
                        destinations[country].Add(city);
                    }
                }
                else if (arguments[0].ToLower() == "remove")
                {
                    string city = arguments[1];
                    bool databaseContainsCity = CityDatabase(city);
                    if (!databaseContainsCity)
                    {
                        Console.WriteLine($"City {city} not found");
                        inputData = Console.ReadLine();
                        continue;
                    }
                    RemoveCity(city);
                }
                else
                {
                    throw new Exception("fb");
                }
                inputData = Console.ReadLine();
            }
            Print(destinations);
        }
        private static void RemoveCity(string city)
        {
            destinations.Values.FirstOrDefault(x => x.Contains(city)).Remove(city);
        }
        private static void Print(Dictionary<string, List<string>> dict)
        {
            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine(
                    $"{kvp.Key} has {kvp.Value.Count} cities and they are: {string.Join(", ", kvp.Value)}");
            }
        }
        private static bool CityDatabase(string city)
        {
            return destinations.Values.FirstOrDefault(x => x.Contains(city)) != null;
        }
    }
}
