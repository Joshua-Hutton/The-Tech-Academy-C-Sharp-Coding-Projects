using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
        string[] strArray = new string[] { "zero", "one", "two", "three", "four" };
        int input = 5;
        do
        {
            Console.WriteLine("Please enter an index for the string array. (0-4)");
            input = Convert.ToInt32(Console.ReadLine());
            if (input < 5)
            {
                Console.WriteLine("You chose :" + strArray[input]);
            }
            else
            {
                Console.WriteLine("Please make a selection between 0 and 4");
            }
        } while (input > 4);

        int[] intArray = new int[] { 0, 1, 2, 3, 4, };
        input = 6;

        do
        {
            Console.WriteLine("Please enter an index for the Int array. (0-4)");
            input = Convert.ToInt32(Console.ReadLine());
            if (input < 5)
            {
                Console.WriteLine("You chose :" + intArray[input]);
            }
            else
            {
                Console.WriteLine("Please make a selection between 0 and 4");
            }
        } while (input > 4);

        List<string> strList = new List<string>();
        strList.Add("Hi");
        strList.Add("Hello");
        strList.Add("Good day");
        strList.Add("Greatings");
        strList.Add("Well met");
        input = 5;
        do
        {
            Console.WriteLine("Please enter an index for the string list. (0-4)");
            input = Convert.ToInt32(Console.ReadLine());
            if (input < 5)
            {
                Console.WriteLine(strList[input]);
            }
            else
            {
                Console.WriteLine("Please make a selection between 0 and 4");
            }
        } while (input > 4);

        Console.ReadLine();
        }
    }