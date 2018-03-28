using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = GetFahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:f2}", celsius);
        }
    }
}
