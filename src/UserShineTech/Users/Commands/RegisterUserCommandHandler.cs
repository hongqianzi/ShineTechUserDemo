using System;
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
            var dto = command.Dto;
            var user = readonlyUserRepository.GetUserByEmail(dto.EmailAddress);
            if (user != null) 
            {
                throw new Exception("此邮箱已被注册");
            }
            _writeBookRepository.CreateUser(dto);
        }
    }



}
