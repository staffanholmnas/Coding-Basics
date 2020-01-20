using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:

            // Give a name and a profession and stores them as strings.
            Console.WriteLine("I will tell a story, but I need some information.\n" +
            "Give a name for main character:");

            string name = Console.ReadLine();

            Console.WriteLine("Give the character a profession:");

            string profession = Console.ReadLine();

            // My own story that uses the name and profession variables multiple times.
            // Commented out this story because it did not pass the test.

            /*Console.WriteLine("\n" + "A tale of " + name + ", the quick learner:\n" + "\n" +
            "Once upon a time " + name + " went for a stroll.\n" +
            "You see, " + name + " was headed for work and everything was fine.\n" +
            "When suddenly " + name + " decided it was time to do something else.\n" +
            "'I want to work as a " + profession + " now.' So " + name + " went straight to\n" +
            "the unemployment office. They said: 'sorry, you don't qualify for working\n" +
            "as a " + profession + ".' " + name + " was sad for a while, then realized,\n" +
            "'perhaps it is best to start studying again!' " + name + " now \n" +
            "works as a " + profession + ". The End.");*/

            // An example story that uses the name exactly twice and the profession 3 times.
            Console.WriteLine("Here is the story:\n" +
            "Once upon a time there was a " + profession + " called " + name + "\n" +
            "On her way to work, " + name + " often pondered what being " + profession + " meant to them.\n" +
            "When you work as a " + profession + " you meet interesting people.\n" +
            name + " enjoys their work as " + profession + ", The end.");


        }
    }
}
