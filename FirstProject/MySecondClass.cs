using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class MyClass
    {
        public int MyInt;
        public string MyString;
        public float myFloat;
        public double MyDouble;

        public MyClass()
        {
            MyInt = 0;
            MyString = "string";
            MyDouble = 0.1f;
            MyDouble = 0.1;
        }

        public void MyMethod()
        {
            Console.WriteLine($"{MyInt}dsdsdsd");
            Console.WriteLine("{0}dsdsdsd", MyInt);
        }
    }
}
