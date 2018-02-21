using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ch13._6_Exception_in_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                NumberValidator nv = new NumberValidator(5);
                NumberValidator nv1 = new NumberValidator(11);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine("Program ended successfully.");
        }
    }
}
