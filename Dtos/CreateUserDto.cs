using System.ComponentModel.DataAnnotations;

namespace Bindy.Dtos
{
    public record CreateUserDto
    {
        [Required]
        public string Name { get; init; }

        [Required]
        public string Username { get; init; }
        
        [Required]
        public string Email { get; init; }

        [Required]
        public string Phone { get; init; }

        [Required]
        public string Website { get; init; }
    }
}