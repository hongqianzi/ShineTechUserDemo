using System;
using System.Collections.Generic;
using System.Text;

namespace UserShineTech.Commands
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : ICommand;
    }
}
