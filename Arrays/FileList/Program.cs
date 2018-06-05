using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Dir(@"C:\");
            foreach (string directories in array)
            {
                Console.WriteLine(Directory);

            }
        }
    }
}

