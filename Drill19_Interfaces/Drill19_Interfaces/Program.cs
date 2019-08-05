using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill19_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();

            quittable.Quit();
            Console.Read();
        }
    }
}
