using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill27_constVar
{
    class Class1
    {
        public Class1(int num1) : this(num1, 2)
        {
        }

        public Class1(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        


        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public void Print()
        {
            Console.WriteLine("num1: {0} num2: {1}", Num1, Num2);
        }

    }
}
