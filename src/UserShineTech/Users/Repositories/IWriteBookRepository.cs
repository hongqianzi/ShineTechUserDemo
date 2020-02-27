using UserShineTech.Users.Dtos;

namespace UserShineTech.Users.Repositories
{
    public interface IWritableUserRepository
    {
        void CreateUser(RegisterUserDto dto);
    }
}