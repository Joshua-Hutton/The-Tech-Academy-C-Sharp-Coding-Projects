using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill11_ExceptionHandleing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 };
            bool go = true;
            do
            {
                try
                {
                    Console.WriteLine("Please enter a whole number you would like to dived by.");
                    int input = Convert.ToInt32(Console.ReadLine());

                    foreach (int i in intList)
                    {

                        Console.WriteLine(i + " / " + input + " = " + i / input);

                    }
                    go = false;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You can't devid by zero");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("I asked for a whole number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            } while (go);

            Console.WriteLine("\nThe Program is over.");
            
            Console.Read();



        }
    }
}
