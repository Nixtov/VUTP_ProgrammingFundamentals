using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();

            if (n == "face")
            {
              
            }
            else if (n == "space")
            {

            }
            else if(n == "volume")
            {
                
            }
        }
       private static void GetCubeFace(int side)
        {
            return Math.Sqrt( 2* Math.Pow (side, 2))
        }

    }
}
