using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill8_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Ahhh, Im a string!";
            string str2 = "Oh, hello.";
            string str3 = "String number three reporting.";

            string upperStr = str1.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append(str2);
            sb.Append(" I'm not sure if I'm sapposed to make this make any sence.\n");
            sb.Append("I'm I sapposed to use the strings from before?\n");
            sb.Append("Ether way, " + str3);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine("\n\n");
            Console.WriteLine(upperStr);
            Console.WriteLine("\r\r");
            Console.WriteLine(sb);

            Console.Read();
            



        }
    }
}
