
using System;

    class Program
    {
        static void Main()
        {

        Console.WriteLine("Please enter a number.");
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        int total = 50 * num;

        Console.WriteLine("The result of you number multiplade by 50 is " + total);

        Console.WriteLine("\nPlease enter another number.");
        input = Console.ReadLine();
        num = Convert.ToInt32(input);
        total = 25 + num;

        Console.WriteLine("The sum of your number plus 25 is: " + total);

        Console.WriteLine("\nPlease enter another number.");
        input = Console.ReadLine();
        double doub = Convert.ToDouble(input);
        double floatingTotal = doub / 12.5;

        Console.WriteLine("The result if dividing your number by 12.5 is: " + floatingTotal);

        Console.WriteLine("\nPlease enter another number.");
        input = Console.ReadLine();
        doub = Convert.ToDouble(input);
        bool greater = doub > 50;

        Console.WriteLine("Is Your number greater then 50:" + greater);

        Console.WriteLine("\nPlease enter another number.");
        input = Console.ReadLine();
        doub = Convert.ToDouble(input);
        floatingTotal = doub % 7;

        Console.WriteLine("The remander of your number devided by 7 is: " + floatingTotal);
        Console.Read();
    }
    }
