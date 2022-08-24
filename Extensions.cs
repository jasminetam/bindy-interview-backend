using Bindy.Dtos;
using Bindy.Entities;

namespace Bindy
{
    public static class Extensions
   {
    public static UserDto AsDto(this User user){
            return new UserDto
            {

                Id = user.Id,
                Name = user.Name,
                Username = user.Username,
                Email= user.Email,
                Phone = user.Phone,
                Website = user.Website,
                CreatedDate = user.CreatedDate,

            };
        }
   }
}