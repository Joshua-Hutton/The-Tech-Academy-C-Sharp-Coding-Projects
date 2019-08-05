
using System;

    class Program
    {
        static void Main(string[] args)
        {

        string ageStr;
        string duiStr;
        string ticketsStr;
        int check = 0;
        int age = 0;
        int tickets = 0;
        bool dui = false;

        Console.WriteLine("Welcome to the car insurance approval thing!\n");

        while (check == 0)
        {
            Console.WriteLine("What is your age?");
            ageStr = Console.ReadLine();
            if (int.TryParse(ageStr, out age))
            {
                age = Convert.ToInt32(ageStr);
                check++;
            }
            else
            {
                Console.WriteLine("Please enter a numaric value!");
            }
        }

        while (check == 1)
        {
            Console.WriteLine("Have you ever had a DUI? Enter \"true\" or \"false\"");
            duiStr = Console.ReadLine();
            if (duiStr == "true" || duiStr == "false")
            {
                dui = Convert.ToBoolean(duiStr);
                check++;
            }
            else
            {
                Console.WriteLine("Please enter true or false");
            } 
        }

        while (check == 2)
        {
            Console.WriteLine("How many speeding tickets do you have?");
            ticketsStr = Console.ReadLine();
            if(int.TryParse(ticketsStr, out tickets))
            {
                tickets = Convert.ToInt32(ticketsStr);
                check++;
            }
            else
            {
                Console.WriteLine("Please enter a numaric value!");
            }
        }

        Console.WriteLine("Qualified?");
        Console.WriteLine(age > 15 && dui == false && tickets < 4);
        Console.Read();

        }
    }

