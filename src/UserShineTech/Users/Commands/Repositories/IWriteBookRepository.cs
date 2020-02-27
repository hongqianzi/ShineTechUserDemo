namespace UserShineTech.Users.Commands.Repositories
{
    public interface IWritableUserRepository
    {
        void CreateUser(RegisterUserCommand command);
    }
}