using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill13_MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 stuff = new Class1();
            Console.WriteLine("enter a whole number.");
            stuff.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second whole number");
            stuff.Num2 = Convert.ToInt32(Console.ReadLine());
           
            stuff.Add(stuff.Num1, stuff.Num2);
            Console.Read();
        }
    }
}
