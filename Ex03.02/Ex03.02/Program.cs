using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1;
            int side2;
            int side3;

            Console.WriteLine("Enter the lenght of the first side:");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lenght of the second side:");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lenght of the third side:");
            side3 = Convert.ToInt32(Console.ReadLine());

           
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                Console.WriteLine("It is a valid triangle.");
            }
            
            else
            {
                Console.WriteLine("It is NOT a valid triangle.");
            }

                Console.ReadKey();
        }
    }
}
