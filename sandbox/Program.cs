using System;
using System.Collections.Generic; // This is for using lists, arrays and dictionaries...
using System.IO; // This is for using files.
using System.Linq; // This adds funtionality for lists.
using System.Text; // This is for using StringBuilder.
using System.Text.RegularExpressions; // This is for Regex.

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

            Console.WriteLine();

            // Floating point numbers
            float floatNumber = 21 / 9f + 0.6f;
            double doubleNumber = 21 / (double)9;
            decimal decimalNumber = 21 / 9m;

            // Integers
            byte byteNumberMax = byte.MaxValue;
            sbyte sbyteNumberMax = sbyte.MaxValue;
            short shortNumberMax = short.MaxValue;
            ushort ushortNumberMax = ushort.MaxValue;
            int integerNumberMax = int.MaxValue;
            uint uintegerNumberMax = uint.MaxValue;
            long longNumberMax = long.MaxValue;
            ulong ulongNumberMax = ulong.MaxValue;

            Console.WriteLine(floatNumber + " floatNumber");
            Console.WriteLine(doubleNumber + " doubleNumber");
            Console.WriteLine(decimalNumber + " decimalNumber");
            Console.WriteLine(byteNumberMax + " byteNumberMax");
            Console.WriteLine(sbyteNumberMax + " sbyteNumberMax");
            Console.WriteLine(shortNumberMax + " shortNumberMax");
            Console.WriteLine(ushortNumberMax + " ushortNumberMax");
            Console.WriteLine(integerNumberMax + " integerNumberMax");
            Console.WriteLine(uintegerNumberMax + " uintegerNumberMax");
            Console.WriteLine(longNumberMax + " longNumberMax");
            Console.WriteLine(ulongNumberMax + " ulongNumberMax");

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

// List of sorted inputs.
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


// Abstract_Class

            UserInterface userInterface = new UserInterface();
            userInterface.AddOperation(new PlusOperation());
            userInterface.AddOperation(new MinusOperation());

            userInterface.Start();

// Bitwise

// Bitwise OR, if either of the bits is 1, the result is 1. Otherwise the result is 0.
            int firstNumber = 5, secondNumber = 6, result;
            result = firstNumber | secondNumber; // 00000101 OR 000000110 = 00000111
            Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result); // 5 | 6 = 7

            firstNumber = 14; secondNumber = 11; 
            result = firstNumber | secondNumber; // 00001110 OR 00001011 = 00001111
            Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result); // 14 | 11 = 15

            // Bitwise AND, if either of the bits is 0, the result is 0. Otherwise the result is 1.
            firstNumber = 5; secondNumber = 6; 
            result = firstNumber & secondNumber; // 00000101 AND 000000110 = 00000100
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result); // 5 & 6 = 4

            firstNumber = 14; secondNumber = 11; 
            result = firstNumber & secondNumber; // 00001110 AND 00001011 = 00001010
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result); // 14 | 11 = 10

            // Bitwise XOR, if the corresponding bits are the same, the result is 0. Otherwise, the result is 1.
            firstNumber = 5; secondNumber = 6; 
            result = firstNumber ^ secondNumber; // 00000101 XOR 000000110 = 00000011
            Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, result); // 5 ^ 6 = 3

            firstNumber = 14; secondNumber = 11; 
            result = firstNumber ^ secondNumber; // 00001110 XOR 00001011 = 00000101
            Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, result); // 14 ^ 11 = 5

// Enumerators

Card first = new Card(9, Suit.Spade);

            Console.WriteLine(first);

            if (first.suit == Suit.Spade)
            {
                Console.WriteLine("is a spade");
            }
            else
                Console.WriteLine("is not a spade");

            Console.WriteLine((int)Suit.Spade); // Casting to int.
            Console.WriteLine((int)Suit.Diamond);

            List<Card> list = new List<Card>();

            list.Add(new Card(8, Suit.Club));
            list.Add(new Card(9, Suit.Diamond));
            list.Add(new Card(13, Suit.Heart));
            list.Add(new Card(9, Suit.Spade));

            list.ForEach(Console.WriteLine);
            list.Sort();
            list.ForEach(Console.WriteLine);

// Equals

Book bookObject = new Book("Book object", 2000, "...");
            Book anotherBookObject = new Book("Book object", 2000, "...");

            if (bookObject.Equals(anotherBookObject))
            {
                Console.WriteLine("The books were the same");
            }
            else
            {
                Console.WriteLine("The books weren't the same");
            }
            Console.WriteLine("-------------");
            Console.WriteLine(bookObject);
            Console.WriteLine("-------------");

            Dictionary<Book, string> borrowers = new Dictionary<Book, string>();

            Book bookObject2 = new Book("Book Object", 2000, "...");
            borrowers.Add(bookObject2, "Pekka");
            borrowers.Add(new Book("Test Driven Development", 1999, "..."), "Arto");

            Console.WriteLine(borrowers[bookObject2]);
            Console.WriteLine(borrowers[new Book("Book Object", 2000, "...")]);
            Console.WriteLine(borrowers[new Book("Test Driven Development", 1999, "...")]);


// Exceptions

Grade grade = new Grade(5);

            Console.WriteLine("................");
            Console.WriteLine("Trying to print contents of Text.txt:");
            Console.WriteLine();
            try
            {
                foreach (var item in ReadLines("GradeText.txt"))
                {
                    Console.WriteLine(item);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("................");
            List<string> list = new List<string>();
            list.Add("Steve");
            list.Add("Bill");
            list.Add("Bob");
            list.Add("Evangelica");

            while (true)
            {

                Console.WriteLine("Write a number 1-3 or a get an error:");
                int number = 0;

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Good Job! It's a number.");

                }
                catch (Exception error)
                {
                    Console.Write(error.Message + "\nQuitting");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000); // Because we're using System.Threading;
                    Console.Write(".");

                    break;
                    // throw;
                }
                try
                {

                    Console.Write(list[number]);
                    Console.WriteLine(" is a name from the list.");
                    Console.WriteLine();

                }
                catch (System.Exception)
                {
                    Console.WriteLine("But don't try to print something that ain't on the list.");
                    Console.WriteLine("................");
                    // throw;
                }
                try
                {
                    int divideByZero = 4 / number;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Error! " + e.Message);
                    Console.WriteLine("................");
                }
            }
        }

// Adjaceny list. Namespace Graphs.

            int n = 5;

            List<int>[] graph = new List<int>[n + 1]; // Create an array of lists containing integers.

            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>(); 
            }      
            graph[1].Add(2);
            graph[1].Add(3);
            graph[1].Add(4);
            graph[2].Add(4);
            graph[2].Add(5);
            graph[3].Add(4);
            graph[4].Add(5);

            foreach (int i in graph[1])
            {
                Console.WriteLine(i);
            }

// Edge list. Namespace Graphs.

            List<Edge> edges = new List<Edge>();

            edges.Add(new Edge(1, 2));
            edges.Add(new Edge(1, 3));
            edges.Add(new Edge(1, 4));
            edges.Add(new Edge(2, 4));
            edges.Add(new Edge(2, 5));
            edges.Add(new Edge(3, 4));
            edges.Add(new Edge(4, 5));

            Console.WriteLine(edges[4].end + "\n");

// Adjacency matrix. Namespace Graphs.

            int[,] mat = {{1,1,0,0,1},{0,0,1,1,0}};

            Console.WriteLine(mat[1,4]); // [2nd row, 5th column]

            int[,] matrix = new int[n + 1, n + 1];

            matrix[1, 2] = 1;
            matrix[1, 3] = 1;
            matrix[1, 4] = 1;
            matrix[2, 4] = 1;
            matrix[2, 5] = 1;
            matrix[3, 4] = 1;
            matrix[4, 5] = 1;

            Console.WriteLine(matrix[1, 2] + "\n");

// BFS, Queue. Namespace Graphs.

            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            Console.WriteLine("Dequeuing '{0}'\n", numbers.Dequeue());
            numbers.Enqueue("six");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

// GuiProject. Open a new winform project:

            // Main:
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Copy this to a file named Form1.cs:
            using System.Windows.Forms;

            namespace GuiProject
            {
                public partial class Form1 : Form
                {
                    private TextBox textBox1;
                    private Button button1;
                    private Button button2;
                    public Form1()
                    {
                        InitializeComponent();
                    }
                }
            }
            // Remove comment out from Form1.Designer.cs.
 

// IComparable

            // List of Members
            List<Member> member = new List<Member>();
            // Add three regular members
            member.Add(new Member("mikael", 182));
            member.Add(new Member("matti", 187));
            member.Add(new Member("ada", 184));
            // Add null to show the sorting of null
            member.Add(null);

            // Print each member
            member.ForEach(Console.WriteLine);

            Console.WriteLine("Let's sort the members:");

            // Sort the list
            member.Sort();

            // Print each member
            member.ForEach(Console.WriteLine);

// Inheritance_2

            Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            Console.WriteLine(ollie);
            Person olliePerson = new Person("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            Console.WriteLine(olliePerson);
            Object ollieObject = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            Console.WriteLine(ollieObject);
            Object alice = new Student("Alice", "177 Stewart Ave. Farmington, ME 04938");
            Object steve = new object();
            Console.WriteLine(alice);
            ollie.Study();
            ollie.Study();
            Console.WriteLine(ollie);
            Console.WriteLine(steve);

// Inheritance_3

            List<Point> points = new List<Point>();
            points.Add(new Point(-4, 8));
            points.Add(new ColorPoint(1, 1, "green"));
            points.Add(new ColorPoint(2, 5, "blue"));
            points.Add(new Point3D(5, 2, 8));
            points.Add(new Point(0, 0));

            Console.WriteLine(points[2].ManhattanDistanceFromOrigin());
            Console.WriteLine(points[3]);
            Console.WriteLine();

            foreach (Point p in points)
            {
                Console.WriteLine(p);
            }

// Interfaces_2

            Books book1 = new Books("Fedor Dostojevski", "Crime and Punishment", 2);
            Books book2 = new Books("Robert Martin", "Clean Code", 1);
            Books book3 = new Books("Kent Beck", "Test Driven Development", 0.5);

            CD cd1 = new CD("Pink Floyd", "Dark Side of the Moon", 1973);
            CD cd2 = new CD("Wigwam", "Nuclear Nightclub", 1975);
            CD cd3 = new CD("Rendezvous Park", "Closer to Being Here", 2012);

            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
            Console.WriteLine(cd1);
            Console.WriteLine(cd2);
            Console.WriteLine(cd3);

// LinkedList

            Node n1 = new Node(3, null, null);
            Node n2 = new Node(7, null, n1);
            Node n3 = new Node(2, null, n2);
            Node n4 = new Node(5, null, n3);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;

            Node n = n1;
            while (n != null)
            {
                Console.WriteLine(n.value);
                n = n.next;
            }

// ListInDictionary

            Node n1 = new Node(3, null, null);
            Node n2 = new Node(7, null, n1);
            Node n3 = new Node(2, null, n2);
            Node n4 = new Node(5, null, n3);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;

            Node n = n1;
            while (n != null)
            {
                Console.WriteLine(n.value);
                n = n.next;
            }

// Namespaces

            // Displays "ExampleMethod in OuterNamespace."
            Example outer = new Example();
            outer.ExampleMethod();

            // Displays "ExampleMethod in InnerNamespace."
            OuterNamespace.InnerNamespace.Example inner = new OuterNamespace.InnerNamespace.Example();
            inner.ExampleMethod();

            using (StringWriter sw = new StringWriter())
            {
                // Object will only exist inside this block.
            }

// Randomizer

            WeatherMan forecaster = new WeatherMan();

            // save days of the week to a list
            List<string> days = new List<string>();
            days.Add("Mon");
            days.Add("Tue");
            days.Add("Wed");
            days.Add("Thu");
            days.Add("Fri");
            days.Add("Sat");
            days.Add("Sun");

            Console.WriteLine("Next week's weather forecast:");

            foreach (string day in days)
            {
                string weatherForecast = forecaster.Forecast();

                Console.WriteLine(day + ": " + weatherForecast);
            }

// Recursion1

            // Hello(5);
            // Console.WriteLine(ReturnZero(6));
            // Test(4);
            // Console.WriteLine("----------");
            // TestReturn(4);
            // Console.WriteLine("----------");
            // Console.WriteLine(Sum(10));
            // Console.WriteLine("----------");
            // Console.WriteLine(Factorial(4));
            // Console.WriteLine("----------");
            // Console.WriteLine(Reverse("Greetings!"));
            // Recurse(3);
            Console.WriteLine();
            int[] a = new int[] { 0, 1, 2, 3, 4, 5 };
            int n = 0;
            PrintArray(a, n);
            Console.WriteLine("----------");
            Console.WriteLine(Palindrome("rotator"));
            Console.WriteLine("----------");
            int number = 4;
            int exponent = 7;
            int sum = 1;
            Console.WriteLine(Power(number, exponent, sum));
            Console.WriteLine("----------");
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

// RegularExpressions

            // trolo(lo|la) = trolo + lo OR la
            // * = 0 to infinity of times
            // + = 1 to infinity of times
            // ? = 0 or 1 times
            // {a} = a times
            // {a,b} = a to b times
            // {a,} = a to infinity times
            // ^ = starts at the beginning of the string
            // $ = ends at the end of the string

            Regex trololo = new Regex("^trolo(lo|la){2,3}$");
            string trolo = "trololala";

            if (trololo.IsMatch(trolo))
            {
                Console.WriteLine("Correct form.");
            }
            else
            {
                Console.WriteLine("Incorrect form.");
            }

            // 5{3} = three fives = 555
            // (1|0)* = 1 or 0, zero to infinity times

            Regex fives = new Regex("^5{3}(1|0)*5{3}$");
            string five = "5550101011101010555";

            if (fives.IsMatch(five))
            {
                Console.WriteLine("Correct form.");
            }
            else
            {
                Console.WriteLine("Incorrect form.");
            }

            // [145] = (1|4|5)
            // [2-36-9] = (2|3|6|7|8|9)
            // [a-c]* = (a|b|c), 0 to infinity times

            Regex regex = new Regex("^[145][2-36-9][a-c]*$");
            string str = "19abcba";

            if (regex.IsMatch(str))
            {
                Console.WriteLine("Correct form.");
            }
            else
            {
                Console.WriteLine("Incorrect form.");
            }

// StreamReader

            // Create a new storer that can create files and add text to them.
            Storer storer = new Storer();

            storer.WriteToFile("file.txt", "\nThis is the very first text to be added:\n"); // This line will be deleted by the next StreamWriter.


            // Create new file and add text.
            StreamWriter writer = new StreamWriter("file.txt");
            writer.WriteLine("Hello!");
            writer.WriteLine("This is a new file.");
            writer.WriteLine("Adding another line.");
            writer.WriteLine("Bye!");
            writer.Close();

            // Add text to file.
            StreamWriter addText = new StreamWriter("file.txt", true);
            addText.WriteLine("Hello again, adding text!");
            addText.WriteLine("Add a last line.");
            addText.Write("Bye!");
            addText.Close();

            // Add text to the same file.
            storer.WriteToFile("file.txt", "\nThis is the very last text to be added.\n");
            storer.WriteToFile("file.txt", "\nThis is the very last text to be added.\n");
            storer.WriteToFile("file.txt", "Poop");

            // Create new file.

            StreamWriter newWriter = new StreamWriter("newfile.txt");
            newWriter.WriteLine("Hi!");
            newWriter.Close();
            Storer newStorer = new Storer();
            newStorer.WriteToFile("newfile.txt", "Bye!");

            // Replace the text in a file.
            string str = File.ReadAllText("newfile.txt");
            str = str.Replace("Bye!", "Take care!");
            File.WriteAllText("newfile.txt", str);

            // Going through a larger file and replacing sentences.
            string diary = "file.txt";
            string[] lines = File.ReadAllLines(diary);
            StreamWriter sw = new StreamWriter(diary);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (lines[i].Contains("Hello"))
                {
                    line = "Good evening!";
                }
                sw.WriteLine(line);
            }
            sw.Close();

// StringBuilder

            StringBuilder numbers = new StringBuilder();
            numbers.Append("This string");
            numbers.Append(", this string as well.");
            numbers.Append(" How about 1 more string.");
            Console.WriteLine(numbers.ToString());
            Console.WriteLine();

// StringReader

            string input = "one\n" + "two\n" +
                            "three\n" + "four\n" +
                            "five\n" + "one\n" +
                            "six\n";
            StringReader reader = new StringReader(input);
            Console.WriteLine(input);

            List<string> read = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter an input: ");
                // Redirect the console input to the reader
                Console.SetIn(reader);
                // It is now in memory and will be given to the ReadLine
                // Every linebreak "\n" starts a new line
                // giving the ReadLine six inputs
                string line = Console.ReadLine();
                if (read.Contains(line))
                {
                    break;
                }

                read.Add(line);
            }

            Console.WriteLine("Thank you!");

            if (read.Contains("six"))
            {
                Console.WriteLine("A value that should not have been added to the group was added to it.");
            }

// Switch

            string message = "Give a number 1-3!";
            string error = "Not a valid number!";
            Console.WriteLine(message);
            int n = Convert.ToInt32(Console.ReadLine());
            
            switch (n)
            {
                case 1:
                Console.WriteLine("You chose 1");
                break;
                case 2:
                Console.WriteLine("You chose 2");
                break;
                case 3:
                Console.WriteLine("You chose 3");
                break;
                default:
                Console.WriteLine(error);
                break;
            }

// Ternary

            // Ternary operations (condition ? yes : no)
            int input = new Random().Next(-5, 5);

            string sign;
            if (input >= 0)
            {
                sign = "positive";
            }
            else
            {
                sign = "negative";
            }
            // Is the same as
            string sign = (input >= 0) ? "positive" : "negative";
            Console.WriteLine(sign);

            // Another example

            int number = 3;

            bool isEven;
            if (number % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }
            //  Is the same as
            bool isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven); // False


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

    public static List<string> ReadLines(string fileName)
        {
            List<string> list = new List<string>();
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException();
            }
            string[] lines = File.ReadAllLines(fileName);
            list = new List<string>(lines);  // Casting

            return list;
        }

    public static void Hello(int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Hello!");
                Hello(n - 1);
            }
        }
        public static int ReturnZero(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return ReturnZero(n - 1);
            }
        }

        static void Test(int n)
        {
            Console.Write(n + " ");
            if (n == 1)
            {
                return;
            }

            Test(n - 1);   
            Test(n - 1);  
        }
        static int TestReturn(int n)
        {
            Console.Write(n + " ");
            if (n == 1) return n;
            TestReturn(n - 1);
            return TestReturn(n - 1);
        }

        static long Sum(int n)
        {
            if (n == 0) return 0;
            else return Sum(n - 1) + n;
        }

        static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        static void Recurse(int n)
        {
            Console.WriteLine(n);
            if (n > 0) Recurse(n -1);
            Console.WriteLine(n);
        }
        static string Reverse(string n)
        {
            if (n.Length < 2) return n;
            return Reverse(n.Substring(1, n.Length - 1)) + n[0];
        }
        static int[] PrintArray(int[] a, int n)
        {
            if (n == a.Length) return a;
            Console.WriteLine(a[n]);
            return PrintArray(a, n + 1);
        }
        static bool Palindrome(string n)
        {
            if (n.Length == 1) return true;
            if (n[0] == n[n.Length - 1])
            {
                n = n.Substring(1);
                n = n.Remove(n.Length - 1);
                return Palindrome(n);
            }
            else
            {
                return false;
            }
        }
        static int Power(int a, int b, int sum)
        {
            if (b == 0) return sum;
            sum = sum * a;
            return Power(a, b - 1, sum);
        }
        static int Fibonacci(int a)
        {
            if (a <= 1) return a;
            return Fibonacci(a - 1) + Fibonacci(a - 2);
        }

    */
    }
}








