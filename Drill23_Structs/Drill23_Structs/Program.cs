using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill23_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num;
            num.Amount = 33.0m;
            Console.WriteLine(num.Amount);
            Console.Read();


        }

        public struct Number
        {
            public decimal Amount;

        }

    }
}
