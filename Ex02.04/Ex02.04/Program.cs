using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyRate = 10.50;
            double numOfHoursWorked = 80;
            double grossPay = hourlyRate*numOfHoursWorked;
            double tax = (grossPay*15/100);
            double netPay = grossPay-tax;

            Console.WriteLine("The hourly rate is: " + hourlyRate);
            Console.WriteLine("The number of hours worked is: " + numOfHoursWorked);
            Console.WriteLine("Gross pay is: " + grossPay);
            Console.WriteLine("Rate of tax is: " + tax);
            Console.WriteLine("Net pay is: " + netPay);

            Console.ReadKey();
        }
    }
}
