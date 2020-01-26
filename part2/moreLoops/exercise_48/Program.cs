using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give numbers:"); // Prints a string asking for numbers.
      
      // Declares variables and sets values to zero.
      double sum = 0; 
      int numberOfInputs = 0;
      int even = 0;
      int odd = 0;

      // A while loop is started, ends when user input is -1.
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine()); // Input variable is converted to integer.

        if (input == -1) // Breaks the loop if input is -1.
        {
          break;
        }

        sum += input; // Adds up the inputs and names the variable sum.
        numberOfInputs++; // Adds 1 everytime the loop runs and stores the value in a variable.

        if (input%2 == 0) // Divides input by 2 and if the remainder is equal to zero, then adds 1 to variable even.
        {
          even++;
        }
        
        else // Otherwise the input must be odd and adds 1 to the variable odd.
        {
          odd++;
        }
      }

      double average = sum/numberOfInputs; // The average is calculated by dividing sum by the number of inputs.

      // Somve messages are printed along with all of the variables.
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + numberOfInputs);
      Console.WriteLine("Average: " + average);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);
    }
  }
}
