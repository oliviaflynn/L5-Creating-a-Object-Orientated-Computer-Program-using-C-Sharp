using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._08
{
    class Program
    {
        static void Main(string[] args)
        {
            double netPrice = 394; //net price            
            double taxPerNight;
            double roomFees = 3.50; // per room per night
            double totalAfterTax;
            double totalCostUSD;
            double totalCostEUR;

            taxPerNight = netPrice *14.75 / 100;

            totalAfterTax = netPrice + taxPerNight;
            totalAfterTax = totalAfterTax + roomFees;
            totalAfterTax = totalAfterTax * 5;
            totalCostUSD = totalAfterTax;
            totalCostEUR = totalAfterTax / 1.25;

            Console.WriteLine("The total cost for five nights in USD is: " + Math.Round(totalAfterTax, 2));
            Console.WriteLine("The total cost for five nights in EUR is: " + Math.Round(totalCostEUR, 2));

            Console.ReadKey();


        }
    }
}
