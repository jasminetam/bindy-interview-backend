using System;

namespace Bindy.Dtos
{
        public record UserDto
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
