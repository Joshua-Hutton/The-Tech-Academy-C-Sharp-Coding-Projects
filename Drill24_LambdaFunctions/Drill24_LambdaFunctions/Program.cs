using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill24_LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            string[] fNames = new string[] { "Josh", "Joe", "Bob", "Phil", "Mary", "Joe", "Ned", "Chuck", "Jim", "Peter" };
            string[] lNames = new string[] { "Hutton", "Johnson", "Marley", "Cheese", "Hanson", "Philips", "Stark", "Foo", "Duglus", "Griffen" };
            


            for(int i = 0; i<10; i++)
            {
                Employee employee = new Employee();
                employee.FirstName = fNames[i];
                employee.LastName = lNames[i];
                employee.Id = i + 1;
                employees.Add(employee);

            }

          
            List<Employee> newEmployees = new List<Employee>();

            foreach(Employee e in employees)
            {
                if (e.FirstName == "Joe")
                {
                    newEmployees.Add(e);
                }
            }

          

            List<Employee> list3 = new List<Employee>();

            list3 = employees.Where(x => x.FirstName == "Joe").ToList();

           

            List<Employee> list4 = new List<Employee>();
            list4 = employees.Where(x => x.Id > 5).ToList();

            

        }
    }
}
