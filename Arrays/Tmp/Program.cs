using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Directory.GetFiles(@"C:\users\");
           // string[] array2 = Directory.GetDirectories(@"C:\users\");
            foreach (string files in array1)
            {
                Console.WriteLine(files);
            }
            // foreach (string files in array2)
            {
              //  Console.WriteLine(files);
            }
        }
    }
}