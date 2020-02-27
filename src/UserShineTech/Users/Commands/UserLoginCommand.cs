using ShineTech.CQRS.Command.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using UserShineTech.Users.Dtos;

namespace UserShineTech.Users.Commands
{
    public class UserLoginCommand : ICommand
    {
        public UserLoginDto Dto { get; set; }
        public UserLoginCommand(UserLoginDto dto)
        {
            Dto = dto;
        }
    }



}
