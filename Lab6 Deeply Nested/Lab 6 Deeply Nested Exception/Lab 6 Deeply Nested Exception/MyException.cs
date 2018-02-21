using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Deeply_Nested_Exception
{
    class MyException : Exception
    {
        public MyException() : base("My Custom Exception.")
        {

        }

        public MyException(string msg) : base(msg)
        {

        }

        public MyException(string msg, Exception inner) : base(msg, inner)
        {

        }
    }
}
