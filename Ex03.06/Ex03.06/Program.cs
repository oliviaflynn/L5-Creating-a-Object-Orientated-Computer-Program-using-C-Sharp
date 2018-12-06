using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a single letter to check if it is a Vowel or Consonant.");
            string letter = Convert.ToString(Console.ReadLine()).ToUpper();

            switch (letter)
              {
                case "A" : case "E": case "I": case "O": case "U":
                    Console.WriteLine("This is a Vowel.");
                break;
                default:
                    Console.WriteLine("This is a consonant.");
                    break;
                }

            Console.ReadKey();

        }
    }
}
