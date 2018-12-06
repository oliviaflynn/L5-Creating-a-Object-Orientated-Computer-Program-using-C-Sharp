using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;

            Console.Write("Please Enter Amount for Withdraw : ");
            money = Convert.ToInt32(Console.ReadLine());


            int twenties = money / 20;           
            int tens = money % 20 / 10;
            int fives = money % 10 / 5;
            int ones = money % 5 / 1;

            Console.WriteLine("20s = " + twenties + " 10s =" + tens + " 5s = " + fives + " 1s = " + ones);

            Console.ReadKey();
        }
    }
}
