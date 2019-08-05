
using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("\nPerson 1:\n\nPlease Enter Hourly Rate.");
        string p1Rate = Console.ReadLine();
        Console.WriteLine("Please enter Hours worked per week.");
        string p1Hours = Console.ReadLine();

        Console.WriteLine("\n\nPerson 2:\n\nPlease Enter Hourly Rate.");
        string p2Rate = Console.ReadLine();
        Console.WriteLine("Please enter Hours worked per week.");
        string p2Hours = Console.ReadLine();

        double p1RateConvt = Convert.ToDouble(p1Rate);
        double p1HoursConvrt = Convert.ToDouble(p1Hours);
        double p2RateConvt = Convert.ToDouble(p2Rate);
        double p2HoursConvrt = Convert.ToDouble(p2Hours);

        double p1Salary = p1RateConvt * p1HoursConvrt;
        double p2Salary = p2RateConvt * p2HoursConvrt;

        Console.WriteLine("\nWeekly Salery of Person 1:");
        Console.WriteLine("$" + p1Salary);
        Console.WriteLine("\nWeekly Salery of Person 2:");
        Console.WriteLine("$" + p2Salary);

        Console.WriteLine("\nDoes Person 1 make more money then person 2?");
        Console.WriteLine(p1Salary > p2Salary);

        Console.Read();



    }
    }

