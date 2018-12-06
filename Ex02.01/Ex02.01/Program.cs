using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 197;
            int hour = (minutes/60);
            int reminderMins = minutes - (60 * hour);



            Console.WriteLine(hour +" hours " + reminderMins + " mins");

            Console.ReadKey();
            


        }
    }
}
