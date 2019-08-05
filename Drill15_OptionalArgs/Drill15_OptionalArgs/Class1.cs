using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill15_OptionalArgs
{
    class Class1
    {
        public int TheOneMethodToRuleThemAll(int num1, int num2 = 42)
        {
            int answer = num1 * 6 / 2 + num2;
            return answer;
        }
    }
}
