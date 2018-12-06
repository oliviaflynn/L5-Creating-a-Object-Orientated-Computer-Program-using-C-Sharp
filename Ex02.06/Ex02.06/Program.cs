using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._06
{
    class Program
    {
        public static int number = 1000;
        

        static void Main(string[] args)
        {
            Console.WriteLine("Total savings plus intrest is: " + Intrest(1000));

            Console.ReadKey();
        }

        public static double Intrest(int number)
        {
           return number + (double)number * 5 /100;
        }
    }
}
