using UserShineTech.Users.Commands;
using UserShineTech.Users.Dtos;

namespace UserShineTech.Users.Repositories
{
    public interface IReadonlyUserRepository
    {
        bool Login(UserLoginCommand command);
        UserItemDto GetUserByEmail(string emailAddress);
    }
}