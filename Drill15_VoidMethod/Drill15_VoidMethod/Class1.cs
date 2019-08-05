using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill15_VoidMethod
{
    static class Class1
    {
        public static void HalfNumber(int num)
        {
            int temp = num / 2;
            Console.WriteLine("half of {0} is about {1}", num, temp);
        }

        public static void Method(out int num)
        {
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());

        }

        public static void Method(int number, out int num)
        {
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            int temp = number * num;
            Console.WriteLine("The number you entered maltiplyed by {0} is {1}", number, temp);
        }
       

        
    }
}
