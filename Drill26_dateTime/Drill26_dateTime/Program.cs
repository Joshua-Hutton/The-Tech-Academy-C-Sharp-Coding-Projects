using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill26_dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The time in {0} hours is {1}", input, DateTime.Now.AddHours(input));
            Console.Read();

        }
    }
}
