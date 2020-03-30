using System;
using System.Collections.Generic; // This is for using lists, arrays and dictionaries...
using System.IO; // This is for using files.

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practise reading files.
            // This reads the content as one string.
            string text = File.ReadAllText("text.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("This was done with ReadAllText.");
            Console.WriteLine(text);
            Console.WriteLine();

            // Read the text from a file line by line and store the lines in an array.
            Console.WriteLine("This was done with ReadAllLines.");
            string[] lines = File.ReadAllLines("text.txt");

            // Prints each line in the array.
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            Console.WriteLine("Printing strings from text file in bytes");
            // Experiment with integers in a text file.
            byte[] numbers = File.ReadAllBytes("Integers.txt");
            foreach (byte item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Practice reading from a csv-file.
            string[] csvRecord = File.ReadAllLines("records.csv.txt");
            foreach (string line in csvRecord)
            {
                string[] pieces = line.Split(",");
                Console.WriteLine("Name: " + pieces[0] + ", age: " + pieces[1]);
            }
            Console.WriteLine();

            // Practice using classes and objects.
            Person ada = new Person("Ada");
            Person antti = new Person("Antti");
            Person martin = new Person("Martin");
            Person pekka = new Person("Pekka");
            Person matti = new Person("Matti");
            Person juhana = new Person("Juhana");

            matti.height = 180;
            matti.weight = 86;

            juhana.height = 178;
            juhana.weight = 70;

            ada.height = 160;
            ada.weight = 55;

            antti.height = 189;
            antti.weight = 90;

            martin.height = 124;
            martin.weight = 46;

            pekka.height = 177;
            pekka.weight = 72;

            Console.WriteLine(matti.name + ", body mass index is " + matti.BodyMassIndex());
            Console.WriteLine(juhana.name + ", body mass index is " + juhana.BodyMassIndex());
            Console.WriteLine("");

            for (int i = 0; i < 20; i++)
            {
                ada.GrowOlder();
            }

            for (int i = 0; i < 5; i++)
            {
                martin.GrowOlder();
            }


            int ioof = 0;
            while (ioof < 27)
            {
                pekka.GrowOlder();
                ioof++;
            }

            antti.GrowOlder();

            if (antti.IsOfLegalAge())
            {
                Console.WriteLine(antti.name + " is of legal age");

            }
            else
            {
                Console.WriteLine(antti.name + " is underage");
            }

            if (pekka.IsOfLegalAge())
            {
                Console.WriteLine(pekka.name + " is of legal age");

            }
            else
            {
                Console.WriteLine(pekka.name + " is underage ");
            }


            Console.WriteLine("");
            Console.WriteLine(pekka); // Same as Console.WriteLine(pekka.ToString() )
            Console.WriteLine(antti);
            Console.WriteLine(ada);


            Console.WriteLine();

            ada.GrowOlder();
            antti.GrowOlder();
            pekka.GrowOlder();
            pekka.GrowOlder();


            Console.WriteLine(pekka);
            Console.WriteLine(antti);
            Console.WriteLine(ada);
            Console.WriteLine(martin);

            Console.WriteLine("");
            Console.WriteLine("Pekka's age: " + pekka.name);
            Console.WriteLine("Antti's age: " + antti.name);
            int combined = pekka.age + antti.age;

            Console.WriteLine("Pekka's and Antti's combined age " + combined + " years");


            // Classes exercise ends.
            Console.WriteLine("");
            // Prints the time.
            System.DateTime moment = DateTime.Now;
            Console.WriteLine(moment);

            // Test Equals method and == sign. They're both the same.
            Console.WriteLine();
            int date1 = 4;
            Console.WriteLine(date1);
            int date2 = 7;
            Console.WriteLine(date2);
            Console.WriteLine(date1.Equals(date2));
            Console.WriteLine(date1 == date2);
            Console.WriteLine();


            // Part 8 - Dictionaries

            Dictionary<string, string> postalCodes = new Dictionary<string, string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            postalCodes.Add("00710", "Helsinki");
            postalCodes.Add("90014", "Oulu");
            postalCodes.Add("33720", "Tampere");
            postalCodes.Add("33014", "Tampere");
            postalCodes.Add("99999", null);
            dict.Add("Fiftyfive", 55);
            
            if (!dict.ContainsKey("Threehundred"))
            {
                dict.Add("Threehundred", 300);
            }

            dict.Add("Twentyfour", 24);

            Console.WriteLine(postalCodes["90014"]);
            Console.WriteLine(dict["Threehundred"]);

            Console.WriteLine();
             
            // Both Console.Writelines methods do the same thing.
            foreach (KeyValuePair<string, string> item in postalCodes)
            {
                Console.WriteLine("Key = " + item.Key + ", Value = " + item.Value);
            }
            
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
            

            /* Comment out printing using methods and lists.

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

Console.WriteLine("Age of the oldest: " + oldest); // Prints the oldest person in the list.


Main program ends. */

        }

        /* Comments out methods.


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

    */
    }
}








