namespace UserShineTech.Users.Commands.Repositories
{
    public interface IReadonlyUserRepository
    {
        void Login(UserLoginCommand command);


    }
}