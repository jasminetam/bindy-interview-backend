using System;
using System.Collections.Generic;
using System.Linq;
using Bindy.Entities;

namespace Bindy.Repositories
{

    public class InMemUsersRepository : IUsersRepository
    {
        private readonly List<User> users = new()
        {
            new User {Id = Guid.NewGuid(), Name = "Jenny", Username = "jenny123", Email = "jenny123@gigi.tv", Phone = "111-111-1111", Website="jenjenbaby.com", CreatedDate = DateTimeOffset.UtcNow},
            new User {Id = Guid.NewGuid(), Name = "Peter", Username = "peterpeter", Email = "peterpeter@pooh.net", Phone = "222-222-2222", Website = "peterpanissocool.com", CreatedDate = DateTimeOffset.UtcNow},
            new User {Id = Guid.NewGuid(), Name = "John", Username = "johnnyjo", Email = "johnnyjo@pirate.com", Phone = "333-333-3333", Website = "letssail.net", CreatedDate = DateTimeOffset.UtcNow},
        };

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public User GetUser(Guid id)
        {
            return users.Where(user => user.Id == id).SingleOrDefault();
        }

        public void CreateUser(User user)
        {
            users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var index = users.FindIndex(existingUser => existingUser.Id == user.Id);
            users[index] = user;
        }

        public void DeleteUser(Guid id)
        {
           var index = users.FindIndex(existingUser => existingUser.Id == id);
            users.RemoveAt(index);
        }
    }
}