using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 32;
            

            do
            {
                char output = (char)counter;
                counter++;
                Console.Write(output);
                if (counter == 42 || counter == 52 || counter == 62 || counter == 72 || counter == 82 || counter == 92 || counter == 102 || counter == 112 || counter == 122)
                    {
                        Console.Write("\n");
                    }
                
            }
            while (counter <= 126);

            Console.ReadKey();    
            
        }
    }
}
