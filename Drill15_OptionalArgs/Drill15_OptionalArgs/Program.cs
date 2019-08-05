using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill15_OptionalArgs
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 MurderMushroom = new Class1();
            Console.WriteLine("Enter the First number.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number. (Optional)");
            string input2 = Console.ReadLine();
            int input2Int;

            bool IsNumaric = int.TryParse(input2, out input2Int);
            if (IsNumaric)
            {
                int result = MurderMushroom.TheOneMethodToRuleThemAll(input1, input2Int);
                Console.WriteLine(result);
            }
            else
            {
                int result = MurderMushroom.TheOneMethodToRuleThemAll(input1);
                Console.WriteLine(result);
            }


            
            Console.Read();
        }
    }
}
