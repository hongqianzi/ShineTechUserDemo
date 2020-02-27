using UserShineTech.Users.Dtos;

namespace UserShineTech.Users.Commands.Repositories
{
    public interface IWritableUserRepository
    {
        void CreateUser(RegisterUserDto dto);
    }
}