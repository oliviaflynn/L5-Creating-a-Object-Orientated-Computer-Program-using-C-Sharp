using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int tutitonFee = 4000;
            int bookFee = 500;

            int costOfCollege = tutitonFee + bookFee;

            Console.WriteLine("The cost of college this year will be: " + costOfCollege);

            Console.ReadKey();
        }
    }
}
