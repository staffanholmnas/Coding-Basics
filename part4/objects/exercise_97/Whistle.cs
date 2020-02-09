using System;

namespace exercise_97
{

    public class Whistle 
    {
        private string sound; // Instance variable.

        public Whistle(string whistleSound) // Contstruct.
        {
            this.sound = whistleSound;
        }

        public void Sound() // A method that prints the objects sound.
        {
            Console.WriteLine(this.sound);
        }
    }
}