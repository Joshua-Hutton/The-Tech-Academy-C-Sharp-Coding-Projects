using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drill20_OverloadOperators
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Screw you guys, I'm going home!");
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool temp = employee1.Id == employee2.Id;
            return temp;

        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool temp = employee1.Id != employee2.Id;
            return temp;

        }
    }
}
