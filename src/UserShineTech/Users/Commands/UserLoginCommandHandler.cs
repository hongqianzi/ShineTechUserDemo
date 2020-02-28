using ShineTech.CQRS.Command.Commands;
using UserShineTech.Users.Repositories;

namespace UserShineTech.Users.Commands
{
    public class UserLoginCommandHandler : ICommandHandler<UserLoginCommand>
    {

        private IReadonlyUserRepository _readonlyUserRepository;

        public UserLoginCommandHandler(IReadonlyUserRepository readonlyUserRepository)
        {
            _readonlyUserRepository = readonlyUserRepository;
        }

        public void Execute(UserLoginCommand command)
        {
            var user = _readonlyUserRepository.Login(command);
        }
    }
}
