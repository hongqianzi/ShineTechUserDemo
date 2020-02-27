using System;
using System.Collections.Generic;
using System.Text;
using UserShineTech.Commands;
using UserShineTech.Users.Commands.Repositories;

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
            _readonlyUserRepository.Login(command);
        }
    }
}
