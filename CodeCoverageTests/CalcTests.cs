namespace CodeCoverageTests
{
  public class CalcTests : Calc
  {
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(10, 20, 30)]
    public void Add_Should_ReturnAsExpected(int a, int b, int expected)
    {
      // Arrange
      // Act
      var actual = Add(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 0)]
    public void Subtract_Should_ReturnAsExpected(int a, int b, int expected)
    {
      // Arrange
      // Act
      var actual = Subtract(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 100)]
    public void Multiply_Should_ReturnAsExpected(int a, int b, int expected)
    {
      // Arrange
      // Act
      var actual = Multiply(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 1)]
    public void Divide_Should_ReturnAsExpected(int a, int b, int expected)
    {
      // Arrange
      // Act
      var actual = Divide(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 0)]
    public void Modulus_Should_ReturnAsExpected(int a, int b, int expected)
    {
      // Arrange
      // Act
      var actual = Modulus(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(2, 2, 4)]
    public void Power_Should_ReturnAsExpected(int a, int b, int expected)
    {
      // Arrange
      // Act
      var actual = Power(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 100)]
    public void Square_Should_ReturnAsExpected(int a, int expected)
    {
      // Arrange
      // Act
      var actual = Square(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 1000)]
    public void Cube_Should_ReturnAsExpected(int a, int expected)
    {
      // Arrange
      // Act
      var actual = Cube(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 3628800)]
    public void Factorial_Should_ReturnAsExpected(int a, int expected)
    {
      // Arrange
      // Act
      var actual = Factorial(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 55)]
    public void Fibonacci_Should_ReturnAsExpected(int a, int expected)
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
    public void GCD_Should_ReturnAsExpected(int a, int b, int expected)
    {
      // Arrange
      // Act
      var actual = GCD(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 10, 10)]
    public void LCM_Should_ReturnAsExpected(int a, int b, int expected)
    {
      // Arrange
      // Act
      var actual = LCM(a, b);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(10, 3.1622776601683795)]
    public void Sqrt_Should_ReturnAsExpected(int a, double expected)
    {
      // Arrange
      // Act
      var actual = Sqrt(a);
      // Assert
      Assert.That(actual, Is.EqualTo(expected));
    }
  }
}
