using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Deeply_Nested_Exception
{
    class ClassWithNestedMethods
    {
        public ClassWithNestedMethods()
        {

        }

        public void MethodA()
        {
            MethodB();
        }
        public void MethodB()
        {
            MethodC();
        }
        public void MethodC()
        {
            MethodD();
        }
        public void MethodD()
        {
            MethodE();
        }
        public void MethodE()
        {
            MethodF();
        }
        public void MethodF()
        {
            MethodG();
        }
        public void MethodG()
        {
            MethodH();
        }
        public void MethodH()
        {
            throw new MyException("Custom Exception throw from MethodH\n");
        }
    }
}
