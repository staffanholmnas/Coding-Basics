using System;

namespace Calculators
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Calculator calc = new Calculator();
      calc.Sum(5);
      Console.WriteLine(calc.value);
      calc.Substract(2);
      Console.WriteLine(calc.value);
      calc.Multiply(2);
      Console.WriteLine(calc.value);
      calc.Divide(2);
      Console.WriteLine(calc.value);
      calc.AddTwoToThePowerOf(3);
      Console.WriteLine(calc.value);
      calc.Divide(2);
      Console.WriteLine(calc.value);
    }
  }
}