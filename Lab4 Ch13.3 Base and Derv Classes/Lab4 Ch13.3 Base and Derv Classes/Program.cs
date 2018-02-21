using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ch13._3_Base_and_Derv_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
                Console.WriteLine("\n1) Throw a base class exception, ExcetionA");
                throw new ExceptionA();
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");                
            }
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionB\n" + ex + "\n");
            }
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            }

            try
            {
                Console.WriteLine("\n\n2) Throw a derived-class ExceptionB");
                throw new ExceptionB();
            }
            catch (ExceptionA ex)
            {
                Console.WriteLine("\n\nExceptionB caught in ExceptionA catch block: \n" + ex + "\n");
            }

            try
            {
                Console.WriteLine("\n\n3) About to throw Exception C:");
                throw new ExceptionC("Exception C occurred...");
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionC\n" + ex + "\n");
            }
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionB\n" + ex + "\n");
            }
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionA\n" + ex + "\n");
            }

            try
            {
                Console.WriteLine("\n\n4) InnerException. Calling method that throws Exception.");
                MethodThatThrowsException();
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionC\n\n");
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"InnerException: {ex.InnerException}");
            }
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionB\n" + ex + "\n");
            }
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionA\n" + ex + "\n");
            }

            Console.WriteLine("\n\nProgram Ending Sucessfully");
            Console.ReadKey();
        }

        public static void MethodThatThrowsException()
        {
            try
            {
                Console.WriteLine("Inside method, about to throw Exception C:");
                throw new ExceptionC("Exception C occurred...");
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionC\n" + ex + "\n");
                throw new ExceptionC("Caught exception, re-throwing it back", ex);
            }
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionB\n" + ex + "\n");
            }
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block for ExceptionA\n" + ex + "\n");
            }
        }
    }
}
