using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter code for your marital status. (S = Single, M = Married, W = Widowed, E = Seperated, D = Divorced)");
            string maritalStatus = Convert.ToString(Console.ReadLine()).ToUpper();

            switch (maritalStatus)
            {
                case "S":
                    Console.WriteLine("Single");
                    break;
                case "M":
                    Console.WriteLine("Married");
                    break;
                case "W":
                    Console.WriteLine("Widowed");
                    break;
                case "E":
                    Console.WriteLine("Seperated");
                    break;
                case "D":
                    Console.WriteLine("Divorced");
                    break;
                default:
                    Console.WriteLine("Error: Invalid Code.");
                    break;
                
            }

            Console.ReadKey();
        }
    }
}
