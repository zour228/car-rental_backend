using System;

namespace app.Domain.User
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(string message) : base(message)
        {
        }

        public static UserNotFoundException WithId(Guid id)
        {
            return new UserNotFoundException($"User with id {id} was not found.");
        }
    }
}