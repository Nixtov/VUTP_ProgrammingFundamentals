﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstPointInfo = Console.ReadLine()
                .Split(' ').Select(double.Parse).ToArray();
        }
    }
}
