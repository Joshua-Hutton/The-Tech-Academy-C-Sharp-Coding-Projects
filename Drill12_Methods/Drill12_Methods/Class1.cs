using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill12_Methods
{
    class Class1
    {
        public Class1(int number)
        {
            Num = number;
        } 

        public int Num { get; set; }

        public int HalfNumder(int num)
        {
            num = num / 2;
            return num;

        }

        public int DoubleNumber(int num)
        {
            num = num * 2;
            return num;
        }

        public int PlusItSelf(int num)
        {
            int result = num + num;

            return result;
        }
    }
}
