internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

namespace _16._3._2
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> FindAll()
        {
            return null;
        }
    }

    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }

    public class Book
    {
        public string Title
        { get; set; }
    }
}
