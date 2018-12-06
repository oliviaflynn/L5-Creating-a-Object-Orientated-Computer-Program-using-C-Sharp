using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code: A
            int na = 0;
            while (na < 4)
            {
                na = na + 1;
            }
            Console.WriteLine("The value of na is:" + na);
            // Code: B
            int nb = 25;
            while (nb < 4)
            {
                nb = nb + 1;
            }
            Console.WriteLine("The value of nb is:" + nb);
            // Code: C
            int nc = 25;
            while (nc >= 4)
            {
                nc = nc + 1;
            }
            Console.WriteLine("The value of nc is:" + nc);

            Console.ReadKey();
        }
    }
}

// Prints 4
// Prints 25
// Prints the maximum that the variable type int can hold