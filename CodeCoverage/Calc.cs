using System;

namespace CodeCoverage
{
  public class Calc
  {
    public static void Main()
    {
      var a = Add(5, 5);
      var s = Subtract(5, 5);
      var m = Multiply(5, 5);
      var d = Divide(5, 5);
      var mod = Modulus(5, 5);
      var p = Power(5, 5);
      var sq = Square(5);
      var c = Cube(5);
      var fac = Factorial(5);
      var fib = Fibonacci(5);
      var gcd = GCD(5, 5);
      var lcm = LCM(5, 5);
      var sqrt = Sqrt(5);

      Console.WriteLine($"Add: {a}");
      Console.WriteLine($"Subtract: {s}");
      Console.WriteLine($"Multiply: {m}");
      Console.WriteLine($"Divide: {d}");
      Console.WriteLine($"Modulus: {mod}");
      Console.WriteLine($"Power: {p}");
      Console.WriteLine($"Square: {sq}");
      Console.WriteLine($"Cube: {c}");
      Console.WriteLine($"Factorial: {fac}");
      Console.WriteLine($"Fibonacci: {fib}");
      Console.WriteLine($"GCD: {gcd}");
      Console.WriteLine($"LCM: {lcm}");
      Console.WriteLine($"Sqrt: {sqrt}");
      Console.ReadLine(); // Pause before closing
    }

    public static int Add(int a, int b)
    {
      return a + b;
    }

    public static int Subtract(int a, int b)
    {
      return a - b;
    }

    public static int Multiply(int a, int b)
    {
      return a * b;
    }

    public static decimal Divide(decimal a, decimal b)
    {
      return (a / b);
    }

    public static int Modulus(int a, int b)
    {
      return a % b;
    }

    public static int Power(int a, int b)
    {
      return (int)Math.Pow(a, b);
    }

    public static int Square(int a)
    {
      return a * a;
    }

    public static int Cube(int a)
    {
      return a * a * a;
    }

    public static int Factorial(int a)
    {
      int result = 1;
      for (int i = 1; i <= a; i++)
      {
        result *= i;
      }
      return result;
    }

    public static int Fibonacci(int a)
    {
      int first = 0;
      int second = 1;
      int result = 0;
      for (int i = 2; i <= a; i++)
      {
        result = first + second;
        first = second;
        second = result;
      }
      return result;
    }

    public static int GCD(int a, int b)
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

    public static int LCM(int a, int b)
    {
      return a * b / GCD(a, b);
    }

    public static double Sqrt(int a)
    {
      return Math.Sqrt(a);
    }
  }
}