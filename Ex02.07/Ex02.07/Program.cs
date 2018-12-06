using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._07
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyRate = 25;
            double regularHours = 40;
            double overTimeHours = 13;

           

            Console.WriteLine("Total wage for these hours worked is: " + Wage(hourlyRate, regularHours, overTimeHours));

            Console.ReadKey();

        }

        public static double Wage(double hourlyRate, double regularHours, double overTimeHours)
        {
            double overTimeRate = (hourlyRate * 1.5);
            return (regularHours * hourlyRate) + (overTimeHours * overTimeRate);          
           

        }

    
              
    }
}
