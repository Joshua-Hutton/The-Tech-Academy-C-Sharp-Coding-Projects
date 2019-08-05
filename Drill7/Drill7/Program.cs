using System;

    class Program
    {
        static void Main()
        {
        int count = 0;
        while(count < 10)
        {
            count++;
            Console.WriteLine("While loop Round :" + count);

        }
        count = 0;

        do
        {
            count++;
            Console.WriteLine("Do While loop Round :" + count);
        } while (count < 10);
        Console.Read();
        }
    }

