using UserShineTech.Users.Dtos;

namespace UserShineTech.Users.Commands.Repositories
{
    public interface IReadonlyUserRepository
    {
        bool Login(UserLoginCommand command);
        UserItemDto GetUserByEmail(string emailAddress);
    }
}