using System;

namespace ExceptionsAsExpressions
{

    static class Program
    {
        static void Main()
        {
            // C# 6
            var book = FindBook("Dianiel Suarez");
            if (book == null)
                throw new InvalidOperationException("Could not find book");

            // C# 7
            book = FindBook("Dianiel Suarez") ??
                throw new InvalidOperationException("Could not find book");
        }

        static Book FindBook(string author)
        {
            return new Book(null);
        }
    }

    public class Book
    {
        private readonly IDatabase _database;

        public Book(IDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        /* C# 6
        public Book(IDatabase database)
        {
            if (database == null)
                throw new ArgumentNullException(nameof(database));

            _database = database;
        }*/
    }

    internal class Configuration
    {
        public string MinLoggingLevel { get; set; }
    }

    public interface IDatabase
    {
    }

    // C# 6
    public class InitialisationExpressionOld
    {
        private readonly Configuration _config;

        public InitialisationExpressionOld()
        {
            _config = LoadConfig();
            if (_config == null)
                throw new InvalidOperationException("Could not load config");
        }
        private static Configuration LoadConfig()
        {
            return new Configuration { MinLoggingLevel = "Info" };
        }
    }

    // C# 7
    public class InitialisationExpression
    {
        private readonly Configuration _config = LoadConfig() ??
                                                 throw new InvalidOperationException("Could not load config");

        private static Configuration LoadConfig()
        {
            return new Configuration { MinLoggingLevel = "Info" };
        }
    }
}