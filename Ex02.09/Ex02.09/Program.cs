using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._09
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1 = 25650;
            double r2 = 28350;
            double requiv = 1 / ((1 / r1) + (1/r2));
            
            Console.WriteLine("Resistor one has the value of  " + r1 + " Ohms");
            Console.WriteLine("Resistor two has the value of  " + r2 + " Ohms");
            Console.WriteLine("The resistance of resistors connected in parallel is: " + requiv);

            Console.ReadKey();
        }
    }
}
