using System;
using System.Net.Sockets;

namespace Bindy.Entities
{
    public record User
    {
        public Guid Id { get; init; }
        public string Name { get; init; }

        public string Username { get; init; }

        public string Email { get; init; }
        public string Phone { get; init; }
        public string Website { get; init; }

        public DateTimeOffset CreatedDate { get; init; }
    }
}