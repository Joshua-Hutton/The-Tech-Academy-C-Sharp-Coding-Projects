using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill28_errorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());

                //This is an imperfect way to find birth year. If the month of your birth is later in the year then the current month you will get the
                //year after you were born. Without getting the birth month from the user you will have this inaccuracy, but I feel this best fits the assignment.
                if (age <= 0) throw new InvalidAgeException();
                DateTime birth = DateTime.Now.AddYears(-age); 
                Console.WriteLine("If you are {0} you where born in {1}.", age, birth.Year);
                Console.Read();
            }
            catch(InvalidAgeException)
            {
                Console.WriteLine("This is an invalid age!");
                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry! Something went wrong.");
                Console.Read();
            }
        }
       
    }
}
