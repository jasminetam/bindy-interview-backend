using System;
using System.Collections.Generic;
using Bindy.Entities;

namespace Bindy.Repositories
{
        public interface IUsersRepository
    {
        User GetUser(Guid id);
        IEnumerable<User> GetUsers();
        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(Guid id);
    }
}