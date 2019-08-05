using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill12_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Whole Number");
            int num = Convert.ToInt32(Console.ReadLine());

            Class1 thing = new Class1(num);

            Console.WriteLine("Your number devided in half is :" + thing.HalfNumder(num));
            Console.WriteLine("Your number doubled is :" + thing.DoubleNumber(num));
            Console.WriteLine("Your number added to itself is :" + thing.PlusItSelf(num));






        }
    }
}
