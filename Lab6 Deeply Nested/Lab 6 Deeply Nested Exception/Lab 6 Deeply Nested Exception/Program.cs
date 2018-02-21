using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Deeply_Nested_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ClassWithNestedMethods cwnm = new ClassWithNestedMethods();

            try
            {
                cwnm.MethodA();
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("The stack trace for this exception is:");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
