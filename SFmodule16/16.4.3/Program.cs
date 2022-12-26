using Xunit;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}


public class CalculatorTests
{
    [Fact]
    public void AdditionalMustReturnCorrectValue()
    {
        var calculator = new Calculator();
        int result = calculator.Addition(50, 10, 34);
        Assert.Equal(94, result);
    }

    [Fact]
    public void MultiplicationMustReturnCorrectValue()
    {
        var calculator = new Calculator();
        int result = calculator.Multiplication(3, 2, 20);
        Assert.Equal(120, result);
    }
}

public class Calculator
{

    public int Addition(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Multiplication(int a, int b, int c)
    {
        return a * b * c;
    }

}