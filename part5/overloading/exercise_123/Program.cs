using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      // Creates 2 new objects. Counter2 takes a starting value as a parameter, counter has starting value 0.
      // Then calls the methods for increasing and decreasing with 1 or a specified amount. 
      Counter counter = new Counter();
      Counter counter2 = new Counter(5);

      counter.Increase();
      counter.Increase();
      Console.WriteLine(counter.value);
      counter.Increase(12);
      Console.WriteLine(counter.value);
      counter.Decrease();
      counter.Decrease(3);
      Console.WriteLine(counter.value);

      Console.WriteLine();

      counter2.Decrease();
      Console.WriteLine(counter2.value);
      counter2.Increase(50);
      Console.WriteLine(counter2.value);
      counter2.Increase();
      Console.WriteLine(counter2.value);
      counter2.Decrease(30);
      Console.WriteLine(counter2.value);
    }
  }
}
