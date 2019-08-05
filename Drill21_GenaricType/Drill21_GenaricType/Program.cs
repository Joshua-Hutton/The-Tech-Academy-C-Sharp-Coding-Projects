using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill21_GenaricType
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "thing one", "thing two", "thing three" };

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 1, 2, 3, 4, 5 };

            for(int i = 0; i < employee.Things.Count; i++)
            {
                Console.WriteLine(employee.Things[i]);
            }

            for( int i = 0; i < employee1.Things.Count; i++)
            {
                Console.WriteLine(employee1.Things[i]);
            }

            Console.Read();


        }
    }
}
