using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            double page = double.Parse(Console.ReadLine());  
            double cover = double.Parse(Console.ReadLine());  
            int discount = int.Parse(Console.ReadLine());  
            double design = double.Parse(Console.ReadLine());  
            int team = int.Parse(Console.ReadLine());
            double sum = ((page * 899) + (cover * 2))*1.1;
                //* (1 - (discount) / 100);// design)*(1 - team / 100);
            Console.WriteLine(sum);
        }
    }
}
