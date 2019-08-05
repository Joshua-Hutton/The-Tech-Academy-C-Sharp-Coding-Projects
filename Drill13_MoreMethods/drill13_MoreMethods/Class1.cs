using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill13_MoreMethods
{
    class Class1
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public void Add(int num1, int num2)
        {
            num1 = num1 + 6; 
            Console.WriteLine("number 2 is {0}",num2);

        }
    }
}
