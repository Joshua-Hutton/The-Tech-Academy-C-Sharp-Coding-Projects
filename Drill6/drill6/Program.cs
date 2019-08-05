using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter the package weight:");
        int waight = Convert.ToInt32(Console.ReadLine());
        if (waight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

        }
        else
        {
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            double hight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());
            if (width + hight + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                double quote = ((width + hight + length) * waight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + string.Format("{0:0.00}", quote) + "\nThank you.");

            }
        }
        Console.Read();

    }
    }

