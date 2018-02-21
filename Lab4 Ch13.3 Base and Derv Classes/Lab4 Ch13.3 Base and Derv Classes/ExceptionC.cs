using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Ch13._3_Base_and_Derv_Classes
{
    class ExceptionC : ExceptionB
    {
        public ExceptionC() : base("Exception thrown by Exception Class ExceptionC")
        {
            Console.WriteLine("ExceptionC(): In body of exception C.");
        }

        public ExceptionC(string msg) : base(msg)
        {
            Console.WriteLine("ExceptionC(string msg): In body of exception C.");
        }

        public ExceptionC(string msg, Exception inner) : base(msg, inner)
        {
            Console.WriteLine("ExceptionC(string msg, Exception inner): In body of exception C.");
        }
    }
}
