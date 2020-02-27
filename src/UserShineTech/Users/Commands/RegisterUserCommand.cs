using System;
using System.Collections.Generic;
using System.Text;
using UserShineTech.Commands;
using UserShineTech.Users.Dtos;

namespace UserShineTech.Users.Commands
{
    public class RegisterUserCommand : ICommand
    {
        public RegisterUser Dto { get; set; }
        public RegisterUserCommand(RegisterUser dto)
        {
            Dto = dto;
        }
    }



}
