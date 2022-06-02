using System;

namespace ExpressionBodiedSyntax
{
    public class UserList
    {
        private readonly User[] _users =
        {
            new User("fred.bloggs@hotmail.com"),
            new User("Joe.Smith@gmail.com")
        };

        /// Indexer with expression body syntax.
        public User this[int index]
        {
            get => _users[index];
            set => _users[index] = value;
        }
    }

    public class User
    {
        private string _email;

        public string Email
        {
            get => _email;
            set => _email = value;
            //set => throw new NotImplementedException("Set is not allowed on Users");
        }

        public User(string email) => _email = email;
        ~User() => Console.WriteLine($"User {_email} is being destroyed");
    }
}