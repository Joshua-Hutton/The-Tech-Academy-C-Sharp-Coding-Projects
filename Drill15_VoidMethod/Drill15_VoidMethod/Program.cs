using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill15_VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            Class1.HalfNumber(input);
            int num;
            Class1.Method(out num);
            int num2;
            Class1.Method(num, out num2);
            Console.Read();

        }
    }
}
