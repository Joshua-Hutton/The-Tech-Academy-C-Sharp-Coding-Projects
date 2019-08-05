
using System;


class Program
{
    static void Main()
    {
        string course;
        string experence;
        string feedback;
        string strhelp;
        string page;
        string hours;
        bool help;
        int check = 0;


        Console.WriteLine("The Tech Academy\nStudent Daily Report\n");

        Console.WriteLine("\nWhat course are you on?");
        course = Console.ReadLine();

        Console.WriteLine("\nWhat page number are you on?");
        page = Console.ReadLine();

        do
        {
            Console.WriteLine("\nDo you need help with anything? Please enter \"true\" or \"false\".");
            strhelp = Console.ReadLine();
            if (strhelp == "true" || strhelp == "false")
            {
                help = Convert.ToBoolean(strhelp);
                check = 1;
            }
            else
            {
                Console.WriteLine("!!!Please enter true or false as shown!!!");
            }
        } while (check == 0);

        Console.WriteLine("\nWere there any positive experiences you'd like to share? Please be specific.");
        experence = Console.ReadLine();

        Console.WriteLine("\nIs there any other feedback you would like to provide? Please be specific.");
        feedback = Console.ReadLine();

        Console.WriteLine("\nHow many hours did you work today?");
        hours = Console.ReadLine();




        Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");



        Console.Read();
    }
}

