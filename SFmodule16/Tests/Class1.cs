using NUnit.Framework;
using _16._2;


namespace NUnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void SubtractionCorrectionTest()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(10,5)==5);
        }
        [Test]
        public void DivisionCorrectionTest()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(10, 5) == 2);
        }
        [Test]
        public void DivisionDivideByZeroExceptionTest()
        { Calculator calculator = new Calculator();
            Assert.Catch<DivideByZeroException>(() =>calculator.Division(10,0));
        }
    }
}