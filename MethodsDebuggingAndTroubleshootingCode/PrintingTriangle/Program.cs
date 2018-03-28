using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Printline();  
        }

        private static void Printline(int start, int end) { 
        
            int n = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            
        }
    }
}
