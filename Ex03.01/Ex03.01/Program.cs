using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;

            Console.WriteLine("Enter a number between 1 and 1000: ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number between 1 and 1000: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne < numberTwo)
            {
                Console.WriteLine(numberOne + " is the smaller number.");
            }
            
           else if (numberOne == numberTwo)
            {
                Console.WriteLine("The two numbers are equal.");
            }

            else (numberOne > numberTwo);
            {
                Console.WriteLine(numberTwo + " is the smaller number.");
            }

            

            Console.ReadKey();

        }
    }
}
