using Xunit;
using _16._2;
using _16._3._2;
using Moq;

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
        [Fact]
        public void BookTest()
        {
            var list = new List<Book> {
                                          new Book()
                                          {
                                            Title  = "Война и мир"
                                          },
                                          new Book()
                                          {
                                            Title  = "Человек - невидимка"
                                          },
                                          new Book()
                                          {
                                            Title  = "Анна Каренина"
                                          },
                                        };
            var MockIBookRepository = new Mock<IBookRepository>();
            MockIBookRepository.Setup(n => n.FindAll()).Returns(list);

            //Assert.True(MockIBookRepository.Object.FindAll().Any(u => u.Title == "Война и мир"));
            //Assert.True(MockIBookRepository.Object.FindAll().Any(u => u.Title == "Человек - невидимка"));
            //Assert.True(MockIBookRepository.Object.FindAll().Any(u => u.Title == "Анна Каренина"));

            Assert.Contains(MockIBookRepository.Object.FindAll(), Book => Book.Title == "Война и мир");
            Assert.Contains(MockIBookRepository.Object.FindAll(), Book => Book.Title == "Человек - невидимка");
            Assert.Contains(MockIBookRepository.Object.FindAll(), Book => Book.Title == "Анна Каренина");

        }
    }
}