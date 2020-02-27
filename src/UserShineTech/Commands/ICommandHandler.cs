using System;
using System.Collections.Generic;
using System.Text;

namespace UserShineTech.Commands
{
    public interface ICommandHandler<TCommand> where TCommand:ICommand
    {
        void Execute(TCommand command);

    }
}
