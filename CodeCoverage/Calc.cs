using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeCoverage
{
  public class Calc
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      var stringInput = Console.ReadLine();

      bool parsePassed = decimal.TryParse(stringInput, out decimal decInput);
      if (parsePassed)
      {
        GetOperationsFromOneInput(decInput);
        Environment.NewLine.ToString();
      }

      Console.WriteLine("Enter two numbers separated by a comma: ");
      List<string> twoStringInputs = Console.ReadLine()?.Split(',').ToList();

      if (twoStringInputs?.Count == 2 && decimal.TryParse(twoStringInputs[0], out decimal decInput1) && decimal.TryParse(twoStringInputs[1], out decimal decInput2))
      {
        GetOperationsFromTwoInputs(decInput1, decInput2);
        Environment.NewLine.ToString();
      }

      Console.ReadLine(); // Pause before closing
    }

    public static decimal Add(decimal a, decimal b)
    {
      return a + b;
    }

    public static decimal Subtract(decimal a, decimal b)
    {
      return a - b;
    }

    public static decimal Multiply(decimal a, decimal b)
    {
      return a * b;
    }

    public static decimal Divide(decimal a, decimal b)
    {
      return (a / b);
    }

    public static decimal Modulus(decimal a, decimal b)
    {
      return a % b;
    }

    public static decimal Power(decimal a, decimal b)
    {
      return (decimal)Math.Pow((double)a, (double)b);
    }

    public static decimal Square(decimal a)
    {
      return a * a;
    }

    public static decimal Cube(decimal a)
    {
      return a * a * a;
    }

    public static decimal Factorial(decimal a)
    {
      decimal result = 1;
      for (decimal i = 1; i <= a; i++)
      {
        result *= i;
      }
      return result;
    }

    public static decimal Fibonacci(decimal a)
    {
      decimal first = 0;
      decimal second = 1;
      decimal result = 0;
      for (decimal i = 2; i <= a; i++)
      {
        result = first + second;
        first = second;
        second = result;
      }
      return result;
    }

    public static decimal GCD(decimal a, decimal b)
    {
      while (a != b)
      {
        if (a > b)
        {
          a -= b;
        }
        else
        {
          b -= a;
        }
      }
      return a;
    }

    public static decimal LCM(decimal a, decimal b)
    {
      return a * b / GCD(a, b);
    }

    public static decimal Sqrt(decimal a)
    {
      return (decimal)Math.Sqrt((double)a);
    }

    protected static void GetOperationsFromOneInput(decimal userInput)
    {
      GetOperations(userInput, userInput);
    }

    protected static void GetOperationsFromTwoInputs(decimal userInputOne, decimal userInputTwo)
    {
      GetOperations(userInputOne, userInputTwo);
    }

    private static void GetOperations(decimal userInputOne, decimal userInputTwo)
    {
      Console.WriteLine($"Add: {Add(userInputOne, userInputTwo)}");
      Console.WriteLine($"Subtract: {Subtract(userInputOne, userInputTwo)}");
      Console.WriteLine($"Multiply: {Multiply(userInputOne, userInputTwo)}");
      Console.WriteLine($"Divide: {Divide(userInputOne, userInputTwo)}");
      Console.WriteLine($"Modulus: {Modulus(userInputOne, userInputTwo)}");
      Console.WriteLine($"Power: {Power(userInputOne, userInputTwo)}");
      Console.WriteLine($"Square: {Square(userInputOne)}");
      Console.WriteLine($"Cube: {Cube(userInputOne)}");
      Console.WriteLine($"Factorial: {Factorial(userInputOne)}");
      Console.WriteLine($"Fibonacci: {Fibonacci(userInputOne)}");
      Console.WriteLine($"GCD: {GCD(userInputOne, userInputTwo)}");
      Console.WriteLine($"LCM: {LCM(userInputOne, userInputTwo)}");
      Console.WriteLine($"Sqrt: {Sqrt(userInputOne)}");
    }
  }
}