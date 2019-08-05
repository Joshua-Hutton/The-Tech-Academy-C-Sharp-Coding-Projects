using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill10_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strArray = { "stuff ", "more stuff ", "and some things " };
            Console.WriteLine("Please enter some text.");
            string input = Console.ReadLine();

            for (int i = 0; i < strArray.Length; i++) 
            {
                strArray[i] = strArray[i] + input;
            }

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);

            }

            //This is my infinite loop. It end when you press enter.... soo is it still ifinite?
            while(true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter) break;
                Console.WriteLine("This is the loop that never ends!");
               
            }
            int count = 0;
            while(count < 10)
            {
                Console.WriteLine(count);
                count++;
            }

            count = 0;
            while(count <= 15)
            {
                if (count == 0)
                {
                    Console.WriteLine("WEEEEEEE");
                }
                else
                {
                    Console.WriteLine("EEEEEEEE");
                }
                count++;
            }

            List<string> fruits = new List<string> { "apple", "banana", "orange", "strawberry" };
            int check = 0;
            do
            {
                Console.WriteLine("Please pick a fruit.(Apple, Banana, Orange or Strawberry");
                input = Console.ReadLine();
                input = input.ToLower();
                if (fruits.Contains(input))
                {
                    foreach (string fruit in fruits)
                    {
                        if (fruit == input)
                        {
                            Console.WriteLine(fruits.IndexOf(fruit));
                            check++;
                            break;
                        }
                    }
                }else
                {
                    Console.WriteLine("Sorry thats not an option!!!");
                }
            } while (check == 0);

            List<string> names = new List<string> { "Josh", "Bob", "Bob", "Tim", "Tarry", "Phil", "Josh" };
            check = 0;
            count = 0;
            do
            {
                Console.WriteLine("Please enter a name.");
                input = Console.ReadLine();
                if (names.Contains(input))
                {
                    foreach(string name in names)
                    {
                        if (input == name)
                        {
                            Console.WriteLine(input + " was found at index :" + count);
                            check = 1;
                        }
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, " + input + " is not in the list. Try another name.");
                }
            } while (check == 0);


            List<string> temp = new List<string>();

            foreach(string name in names)
            {

                if (temp.Contains(name))
                {
                    Console.WriteLine(name + " is already in list");
                }
                temp.Add(name);
                
            }

          
            Console.Read();

        }
    }
}
