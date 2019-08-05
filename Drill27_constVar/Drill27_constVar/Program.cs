using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill27_constVar
{
    class Program
    {
        static void Main(string[] args)
        {
            const string str = "This string is constant.";

            var varStr = "this is a string";

            Console.WriteLine("{0} : {1}", str, varStr);
            

            Console.WriteLine("enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number.");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Class1 class1 = new Class1(input, input2);

            class1.Print();


            Console.Read();






        }
    }
}
