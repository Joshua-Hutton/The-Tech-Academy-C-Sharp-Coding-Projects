using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill19_Interfaces
{
    class Employee : Person, IQuittable

    
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Screw you guys, I'm going home!");
        }
    }
}
