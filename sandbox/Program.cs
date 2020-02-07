using System;
using System.Collections.Generic;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {   // Practice using classes and objects.
            Person ada = new Person("Ada");
            Person antti = new Person("Antti");
            Person martin = new Person("Martin");

            ada.PrintPerson();
            antti.PrintPerson();
            martin.PrintPerson();

            Console.WriteLine();

            ada.GrowOlder();
            antti.GrowOlder(); // Grows older 2 times.
            antti.GrowOlder();

            ada.PrintPerson();
            antti.PrintPerson();
            martin.PrintPerson();


            // Classes exercise ends.
            Console.WriteLine("");
            // Prints the time.
            System.DateTime moment = DateTime.Now;
            Console.WriteLine(moment);

            // Print Stars in different patterns.

            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            PrintSquare(4);
            PrintRectangle(17, 3);
            PrintTriangle(4);
            PrintRightTriangle(4);

            Console.WriteLine("");

            // Adds a list of names and prints them.
            List<string> list = new List<string>();

            list.Add("Tom");
            list.Add("Steve");
            list.Add("lake");
            list.Add("Agaton");

            list.RemoveAt(3);
            list.ForEach(Console.WriteLine);
            Console.WriteLine("");

            // Adds a list of numbers and prints them. 
            List<double> matrix = new List<double>();

            matrix.Add(2.5);
            matrix.Add(1);
            matrix.Add(5.34);
            matrix.Add(7);

            for (int i = 0; i < matrix.Count; i++)
            {
                Console.WriteLine(matrix[i]);

            }

            if (matrix.Contains(7)) // Checks for a number 7 in the list of values.
            {
                Console.WriteLine("This list has a 7");
            }

            Console.WriteLine("The sum is:");

            double sum = 0;
            foreach (double item in matrix) // Adds all values in the list and prints the sum.
            {
                sum = item + sum;
            }
            Console.WriteLine(sum);
            Console.WriteLine("");
            // Adds an array and some elements.

            int[] values = new int[4];

            values[0] = 2;
            values[1] = 0;
            values[2] = 2;
            values[3] = 0;

            foreach (int print in values)
            {
                Console.Write(print);
            }
            Console.WriteLine("");
            // Adds a new array with 4 elements and values.
            int[] array = { 1, 9, 8, 1 };

            // Can't add more values to the array because it was created with 4 elements.

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            /*
            List<int> listOfAges = new List<int>(); // Creates a new list.

            int age = 0; // Declares an integer called age that is needed later.

            Console.WriteLine("");
            Console.WriteLine("Please enter a name, and age (name,age):");
            Console.WriteLine("Empty line quits.");

            while (true) // A loop that asks for inputs until an empty line is entered.
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                string[] parts = input.Split(","); // Splits the input strings at every comma, each part stored in the array. 

                age = Convert.ToInt32(parts[1]); // Converts the second string entered to an integer stored in the variable age.

                listOfAges.Add(age); // Adds the integer to the list.

            }

            int oldest = OldestAge(listOfAges); // Calls the method OldestAge that searches the list for the largest value. Stores the largest value in oldest.

            Console.WriteLine("Age of the oldest: " + oldest); // Prints the oldest person in the list.*/


        }
        public static void PrintStars(int number) // Method for printing stars.
        {
            // you can print one star with the command
            // Console.Write("*");
            // call the print command n times
            // in the end print a line break with the comand
            // Console.WriteLine("");
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        public static void PrintSquare(int size) // Method for printing squares.
        {
            for (int i = 0; i < size; i++)
            {
                PrintStars(size);
            }
        }
        public static void PrintRectangle(int width, int height) // Method for Printing Rectangles.
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
        }
        public static void PrintTriangle(int size) // Method for printing triangles.
        {
            for (int i = 1; i <= size; i++)
            {
                PrintStars(i);
            }
        }
        public static void PrintSpaces(int number) // Method for printing spaces.
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }
        public static void PrintRightTriangle(int size) // Method for printing a right triangle.
        {
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
            }
        }
        public static int OldestAge(List<int> list) // Method that gets the greatest value from the list.
        {
            int greatest = list[0]; // The first value int the list is the greatest.

            for (int i = 0; i < list.Count; i++) // Iterates through the indices of the list.
            {
                int number = list[i]; // Each value in the list is stored in a variable called number.

                if (greatest < number) // Checks if the value is bigger than the previous value for each iteration.
                {
                    greatest = number; // If the value was smaller, nothing happens. If it was bigger, the value is
                                       // stored in the variable greatest so it can be checked again in the next iteration. 
                }
            }
            return greatest; // Returns the largest value. This method could also be used to return an index.
        }
    }
}








