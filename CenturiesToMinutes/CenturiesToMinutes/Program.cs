﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;

            //  Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {minutes} minutes");
            Console.WriteLine($"{}");
        }
    }
}
