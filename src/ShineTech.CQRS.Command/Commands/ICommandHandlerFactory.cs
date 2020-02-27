using System;
using System.Collections.Generic;
using System.Text;

namespace ShineTech.CQRS.Command.Commands
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : ICommand;
    }
}
