using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Ch13._6_Exception_in_Constructor
{
    class NumberValidator
    {
        public NumberValidator(int num)
        {
            if (num < 11)
            {
                Console.WriteLine($"Number {num} is valid.");
            }
            else
            {
                throw new ArithmeticException($"{num} is invalid. Number must be less than or equal to 10.\n");
            }
        }
    }
}
