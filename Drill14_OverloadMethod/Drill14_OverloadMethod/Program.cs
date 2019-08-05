using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill14_OverloadMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 meaningfulName = new Class1();

            Console.WriteLine("enter a Intager");
            int num = Convert.ToInt32(Console.ReadLine());
            int answer = meaningfulName.DoingSomeStuff(num);
            Console.WriteLine(answer);
            Console.WriteLine("enter a decimal");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            decimal danswer = meaningfulName.DoingSomeStuff(number);
            Console.WriteLine(danswer);
            
            Console.WriteLine("enter a number");
            string str = Console.ReadLine();
            answer = meaningfulName.DoingSomeStuff(str);
            Console.WriteLine(answer);

            Console.Read();
        }
    }
}
