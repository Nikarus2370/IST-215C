using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab100_3_RegExWordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter a sentence:");
            string input = Console.ReadLine();

            Console.WriteLine($"Digits: {Regex.Matches(input, @"\d").Count}, " +
                $"word chars: {Regex.Matches(input, @"\w").Count}, " +
                $"non-word chars: {Regex.Matches(input, @"\W").Count}, " +
                $"whitespace chars: {Regex.Matches(input, @"\s").Count}.");
        }
    }
}
