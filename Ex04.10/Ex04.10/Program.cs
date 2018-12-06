using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //780 answer
            int number = 0;
            int sum = 0;

            for (int i = 0; i <= 39; i++)
            {
                sum = sum + number;
                number++;
                
            }
            Console.WriteLine(sum);
            

            if (sum == (39*(39+1)/2))
            {
                Console.WriteLine("Congratulations, you have sucessfully added up all the numbers together from 0 to 39.");
            }

            Console.ReadKey();
        }

    }
}
