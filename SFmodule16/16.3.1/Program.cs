internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

namespace _16._3._1
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return null;
        }
    }

    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }

    public class User
    {
        public string Name
        {
            get;
            set;
        }
    }
}