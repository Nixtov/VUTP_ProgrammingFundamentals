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
            try
            {
                var root = @"G:\logs";
                DirectorySearch(root);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static void DirectorySearch(string root)
        {
            throw new NotImplementedException();
        }
    }
}
