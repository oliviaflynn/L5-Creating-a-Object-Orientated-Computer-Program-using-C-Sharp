using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * The following program was tested using the following values for the variables:
 * n1=1; n2= 2; n3=3; All different values
 * 
 * n1= 5; n2= 5; n3 =5; n2 and n3 same value
 * 
 * n1= 2; n2= 2; n3=3; n1 and n2 same value
 * 
 * n1= 6; n2 = 3; n3= 3; n2 and n3 same value
 * 
 * n1= 6; n2= 3; n3=6; n1 and n3 same value
 * 
 */

namespace Ex03._08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 6;
            int n2 = 3;
            int n3 = 6;

            if (n1 == n2)
            {
                if (n2 == n3)
                {
                    Console.WriteLine("n1, n2 and n3 have the same value.");
                }

                else
                {
                    Console.WriteLine("n1 and n2 have the same value.");
                }
            }
            
            else if (n1 == n3)
            {
                Console.WriteLine("n1 and n3 have the same value.");
            }

            else if (n2 == n3)
            {
                Console.WriteLine("n2 and n3 have the same value.");
            }
            
            else
            {
                Console.WriteLine("n1, n2 and n3 have different values.");
            }

            Console.ReadKey();
        }
    }
}


