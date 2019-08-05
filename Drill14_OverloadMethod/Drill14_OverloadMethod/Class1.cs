using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill14_OverloadMethod
{
    class Class1
    {
        public int DoingSomeStuff(int number)
        {
            number = number * 1000;
            return number;
        }

        public int DoingSomeStuff(decimal number)
        {
            int temp = Convert.ToInt32(number + 1000);
            return temp;
        }

        public int DoingSomeStuff(string num)
        {
            int temp;
            bool IsNumaric = int.TryParse(num, out temp);
            if (IsNumaric)
            {
                temp = temp + temp;
                return temp;

            }
            else
            {
                Console.WriteLine("This string is not a number");
                return 0;
            }

        }
   
      
    }
}
