using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            int n;
            do
            {
                // Input
                do
                {
                    Console.WriteLine("Enter a number");
                } while (!int.TryParse(Console.ReadLine(), out n));

                Console.WriteLine("Enter ESC to exit programm...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape); 
        }
    }
}
