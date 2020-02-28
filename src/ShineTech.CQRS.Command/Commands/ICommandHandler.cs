using System;
using System.Collections.Generic;
using System.Text;

namespace ShineTech.CQRS.Command.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);


    }
}
