using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04._13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j <= 12; j++)
            {
                if (j == 0)
                {
                    Console.Write("{0,4}", "");
                }
                else
                {
                    Console.WriteLine("{0,4}", j);
                }

                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(i + "\t");
                    Console.Write("|");
                    for (int k = 1; k <= 12; k++)
                    {
                        Console.Write("{0,4}", i * k);
                    }
                    Console.Write("\n");
                }
                Console.ReadKey();
            }
        }
    }
}
