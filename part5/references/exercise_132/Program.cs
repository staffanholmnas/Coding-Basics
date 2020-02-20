using System;

namespace exercise_132
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates a new object with the date as parameters. Prints the ToString representation of the values.
            SimpleDate date = new SimpleDate(13, 2, 2015);
            Console.WriteLine("Friday of the examined week is " + date);

            // Calls a method that creates a clone of the date object called newdate. The parameter passed (7) is used to call another method.
            SimpleDate newDate = date.AfterNumberOfDays(7);

            // Prints the new date for every week and creates a new instance of the object each time.
            int week = 1;
            while (week <= 7)
            {
                Console.WriteLine("Friday after " + week + " weeks is " + newDate);
                newDate = newDate.AfterNumberOfDays(7);

                week = week + 1;
            }

            // Prints the date after 790 days.
            Console.WriteLine("The date after 790 days from the examined Friday is ... try it out yourself!");
            Console.WriteLine("Try " + date.AfterNumberOfDays(790));
        }
    }
}
