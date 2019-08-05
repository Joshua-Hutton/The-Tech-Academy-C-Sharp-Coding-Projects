using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill22_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter A day of the Week.");
                string input = Console.ReadLine();
                Days days;
                Enum.TryParse(input, true, out days);

                Console.WriteLine(days);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.Read();
        }
        public enum Days
        {
            Monday, 
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
