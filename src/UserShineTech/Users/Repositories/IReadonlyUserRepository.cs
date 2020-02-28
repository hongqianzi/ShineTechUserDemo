using UserShineTech.Users.Commands;
using UserShineTech.Users.Dtos;

namespace UserShineTech.Users.Repositories
{
    public interface IReadonlyUserRepository
    {
        UserDto Login(UserLoginCommand command);
        UserItemDto GetUserByEmail(string emailAddress);
    }
}