using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid number for a month: (1-12)");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("31 days in January.");
                    break;
                case 2:
                    Console.WriteLine("31 days in February, expect during leap year it has 29 days.");
                    break;
                case 3:
                    Console.WriteLine("31 days in March.");
                    break;
                case 4:
                    Console.WriteLine("30 days in April.");
                    break;
                case 5:
                    Console.WriteLine("31 days in May.");
                    break;
                case 6:
                    Console.WriteLine("30 days in June.");
                    break;
                case 7:
                    Console.WriteLine("31 days in July.");
                    break;
                case 8:
                    Console.WriteLine("31 days in August.");
                    break;
                case 9:
                    Console.WriteLine("30 days in September.");
                    break;
                case 10:
                    Console.WriteLine("31 days in October.");
                    break;
                case 11:
                    Console.WriteLine("30 days in November.");
                    break;
                case 12:
                    Console.WriteLine("31 days in December.");
                    break;
                default:
                    Console.WriteLine("Number entered does not correspond with a valid month.");
                    break;

            }

            Console.ReadKey();

        }
    }
}
