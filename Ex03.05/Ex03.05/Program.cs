using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a day of the week.");
            string day = Convert.ToString(Console.ReadLine()).ToUpper(); // takes user input converts to string and changes all to upper case

            switch (day)
            {
                case ("SUNDAY"):
                    Console.Write(0);
                    break;
                case ("MONDAY"):
                    Console.Write(1);
                    break;
                case ("TUESDAY"):
                    Console.Write(2);
                    break;
                case ("WEDNESDAY"):
                    Console.Write(3);
                    break;
                case ("THURSDAY"):
                    Console.Write(4);
                    break;
                case ("FRIDAY"):
                    Console.Write(5);
                    break;
                case ("SATURDAY"):
                    Console.Write(6);
                    break;
                default:
                    Console.WriteLine("Please enter a vaild day of the week in english and spelled correctly.");
                    break;

                    
            }
            Console.ReadKey();
        }
    }
}
