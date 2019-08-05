using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill25_fileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number to be logged!");
            string input = Console.ReadLine();
            int num;
            bool isNum = int.TryParse(input, out num);
            if (isNum)
            {
                File.WriteAllText("C:\\Users\\joshua hutton\\Desktop\\drill25.txt", input);

                Console.WriteLine(File.ReadAllText("C:\\Users\\joshua hutton\\Desktop\\drill25.txt"));
            }
            else
            {
                Console.WriteLine("that is not a whole number.");
            }           
            Console.Read();

        }
    }
}
