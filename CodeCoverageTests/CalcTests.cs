namespace CodeCoverageTests
{
  public class CalcTests : Calc
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestGetOperationsFromOneInput()
    {
      // Arrange
      decimal userInput = 5;
      string expectedOutput = "Add: 10" + Environment.NewLine +
                              "Subtract: 0" + Environment.NewLine +
                              "Multiply: 25" + Environment.NewLine +
                              "Divide: 1" + Environment.NewLine +
                              "Modulus: 0" + Environment.NewLine +
                              "Power: 3125" + Environment.NewLine +
                              "Square: 25" + Environment.NewLine +
                              "Cube: 125" + Environment.NewLine +
                              "Factorial: 120" + Environment.NewLine +
                              "Fibonacci: 5" + Environment.NewLine +
                              "GCD: 5" + Environment.NewLine +
                              "LCM: 5" + Environment.NewLine +
                              "Sqrt: 2.23606797749979" + Environment.NewLine;

      // Act
      using (var stringWriter = new StringWriter())
      {
        Console.SetOut(stringWriter);
        GetOperationsFromOneInput(userInput);
        string actualOutput = stringWriter.ToString();

        // Assert
        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
      }
    }

    [Test]
    public void TestGetOperationsFromTwoInputs()
    {
      // Arrange
      decimal userInput1 = 10;
      decimal userInput2 = 5;
      string expectedOutput = "Add: 15" + Environment.NewLine +
                              "Subtract: 5" + Environment.NewLine +
                              "Multiply: 50" + Environment.NewLine +
                              "Divide: 2" + Environment.NewLine +
                              "Modulus: 0" + Environment.NewLine +
                              "Power: 100000" + Environment.NewLine +
                              "Square: 100" + Environment.NewLine +
                              "Cube: 1000" + Environment.NewLine +
                              "Factorial: 3628800" + Environment.NewLine +
                              "Fibonacci: 55" + Environment.NewLine +
                              "GCD: 5" + Environment.NewLine +
                              "LCM: 10" + Environment.NewLine +
                              "Sqrt: 3.16227766016838" + Environment.NewLine;

      // Act
      using (var stringWriter = new StringWriter())
      {
        Console.SetOut(stringWriter);
        GetOperationsFromTwoInputs(userInput1, userInput2);
        string actualOutput = stringWriter.ToString();

        // Assert
        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
      }
    }

    [TestCase(10, 20, 30)]
    public void Add_Should_ReturnAsExpected(decimal a, decimal b, decimal expected)
    {
      // Arrange
      // Act
      var actual = Add(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 0)]
    public void Subtract_Should_ReturnAsExpected(decimal a, decimal b, decimal expected)
    {
      // Arrange
      // Act
      var actual = Subtract(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 100)]
    public void Multiply_Should_ReturnAsExpected(decimal a, decimal b, decimal expected)
    {
      // Arrange
      // Act
      var actual = Multiply(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 1)]
    public void Divide_Should_ReturnAsExpected(decimal a, decimal b, decimal expected)
    {
      // Arrange
      // Act
      var actual = Divide(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 0)]
    public void Modulus_Should_ReturnAsExpected(decimal a, decimal b, decimal expected)
    {
      // Arrange
      // Act
      var actual = Modulus(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(2, 2, 4)]
    public void Power_Should_ReturnAsExpected(decimal a, decimal b, decimal expected)
    {
      // Arrange
      // Act
      var actual = Power(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 100)]
    public void Square_Should_ReturnAsExpected(decimal a, decimal expected)
    {
      // Arrange
      // Act
      var actual = Square(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 1000)]
    public void Cube_Should_ReturnAsExpected(decimal a, decimal expected)
    {
      // Arrange
      // Act
      var actual = Cube(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 3628800)]
    public void Factorial_Should_ReturnAsExpected(decimal a, decimal expected)
    {
      // Arrange
      // Act
      var actual = Factorial(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 55)]
    public void Fibonacci_Should_ReturnAsExpected(decimal a, decimal expected)
    {
      // Arrange
      // Act
      var actual = Fibonacci(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 10)]
    [TestCase(10, 20, 10)]
    [TestCase(30, 10, 10)]
    public void GCD_Should_ReturnAsExpected(decimal a, decimal b, decimal expected)
    {
      // Arrange
      // Act
      var actual = GCD(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 10)]
    public void LCM_Should_ReturnAsExpected(decimal a, decimal b, decimal expected)
    {
      // Arrange
      // Act
      var actual = LCM(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 3.1622776601683795)]
    public void Sqrt_Should_ReturnAsExpected(decimal a, decimal expected)
    {
      // Arrange
      // Act
      var actual = Sqrt(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }
  }
}
