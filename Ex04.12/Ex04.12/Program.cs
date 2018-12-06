using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Olivia";

            char[] characters = name.ToCharArray();

            foreach (char item in characters)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }        
    }
}
