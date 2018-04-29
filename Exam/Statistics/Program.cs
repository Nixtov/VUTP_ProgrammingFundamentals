using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int agents = int.Parse(Console.ReadLine());
            double transactions = SumTransactions(agents);
            double sumFromAgents = transactions / agents;
            Console.WriteLine("{0:F3}", sumFromAgents);
        }
        static double SumTransactions(int numberOfAgents)
        {
            double sumFromTransactions = 0;
            for (int i = 0; i < numberOfAgents; i++)
            {
                int numberOfDeals = int.Parse(Console.ReadLine());
                for (int j = 0; j < numberOfDeals; j++)
                {
                    double quadrature = double.Parse(Console.ReadLine());
                    double pricePerSquare = double.Parse(Console.ReadLine());
                    double valueFromTransaction = (double)quadrature * pricePerSquare;
                    sumFromTransactions = sumFromTransactions + valueFromTransaction;
                }
            }
            return sumFromTransactions;
        }
    }
}
