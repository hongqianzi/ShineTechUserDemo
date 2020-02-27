using ShineTech.CQRS.Command.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using UserShineTech.Users.Dtos;

namespace UserShineTech.Users.Commands
{
    public class RegisterUserCommand : ICommand
    {
        public RegisterUserDto Dto { get; set; }
        public RegisterUserCommand(RegisterUserDto dto)
        {
            Dto = dto;
        }
    }



}
