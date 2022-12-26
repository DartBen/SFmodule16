using NUnit.Framework;
using Moq;
using _16._2;
using _16._3._1;



namespace NUnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void SubtractionCorrectionTest()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(10, 5) == 5);
        }
        [Test]
        public void DivisionCorrectionTest()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(10, 5) == 2);
        }
        [Test]
        public void DivisionDivideByZeroExceptionTest()
        {
            Calculator calculator = new Calculator();
            Assert.Catch<DivideByZeroException>(() => calculator.Division(10, 0));
        }

        [Test]
        public void UserTest()
        {
            var list = new List<User> {
                                          new User()
                                          {
                                            Name = "Антон"
                                          },
                                          new User()
                                          {
                                            Name = "Иван"
                                          },
                                          new User()
                                          {
                                            Name = "Алексей"
                                          },
                                        };
            var MockIUserRepository = new Mock<IUserRepository>();
            MockIUserRepository.Setup(n => n.FindAll()).Returns(list);

            Assert.That(MockIUserRepository.Object.FindAll().Any(u=>u.Name== "Антон"));
            Assert.That(MockIUserRepository.Object.FindAll().Any(u => u.Name == "Иван"));
            Assert.That(MockIUserRepository.Object.FindAll().Any(u => u.Name == "Алексей"));
        }
    }
}