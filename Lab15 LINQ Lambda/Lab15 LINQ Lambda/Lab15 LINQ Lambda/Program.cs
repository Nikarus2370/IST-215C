using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_LINQ_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] array = { "banana", "apple", "peach", "cherry", "strawberry" };
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango",
                "grape", "orange", "blueberry", "passionfruit", "strawberry" };
            string[] sites = { "1", "2", "4-8", "3-15" };

            Console.WriteLine("a) Sort using OrderedBy extension method, then display");
            var output = array.OrderBy(a => new string(a.ToCharArray()));
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");



            Console.WriteLine("b) Reverse Sort the string and then display");
            IEnumerable<string> reversedArray = array.Reverse();
            foreach (var item in reversedArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("c) Sort in ascending order using LINQ");
            var asc = from item in array
                      orderby item
                      select item;


            foreach (var item in asc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");


            Console.WriteLine("d) Sort in descending order using LINQ");
            var dsc = from item in array
                      orderby item descending
                      select item;


            foreach (var item in dsc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");


            Console.WriteLine("e) Reverse each string in the array and display");

        }
    }
}
