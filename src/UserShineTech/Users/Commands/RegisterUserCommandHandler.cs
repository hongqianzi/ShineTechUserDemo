using UserShineTech.Commands;
using UserShineTech.Users.Commands.Repositories;

namespace UserShineTech.Users.Commands
{
    public class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand>
    {

        private readonly IWritableUserRepository _writeBookRepository;
        private readonly IReadonlyUserRepository readonlyUserRepository;
        
        public RegisterUserCommandHandler(IWritableUserRepository writeBookRepository)
        {
            _writeBookRepository = writeBookRepository;
        }
        public void Execute(RegisterUserCommand command)
        {
            _writeBookRepository.CreateUser(command);
        }
    }



}
