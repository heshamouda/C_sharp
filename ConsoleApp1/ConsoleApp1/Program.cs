using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        public static string title = "c# App";
        public static int whichPart;
        static void Main(string[] args)
        {
            whichPart = 2;
            var message = string.Format("welcome to {0} Part {1}", title, whichPart);
            Console.WriteLine("Welcome to C# Part 1!");
            Console.WriteLine("Press the enter key to continue.");
            Console.ReadLine();
            Console.WriteLine(message);
            var ciy = "Basel";
            var temperature = 12.4f;
            var currentDate = DateTime.Now;
            var welcome = string.Format("Welcome to {0}. The time is {1}. The temperature is {2}.", ciy, currentDate, temperature);
            Console.WriteLine(welcome);

            Console.WriteLine("Press the enter key to exit.");
            Console.ReadLine();
        }
    }
}