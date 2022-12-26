using Xunit;
using _16._2;

namespace XUnitTests
{
    public class Class1
    {
        [Fact]
        public void SubtractionCorrectionTest()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(10, 5) == 5);
        }
        [Fact]
        public void DivisionCorrectionTest()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(10, 5) == 2);
        }
        [Fact]
        public void DivisionDivideByZeroExceptionTest()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(()=>calculator.Division(10, 0));
        }
    }
}