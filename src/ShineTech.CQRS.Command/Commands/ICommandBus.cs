using System;
using System.Collections.Generic;
using System.Text;

namespace ShineTech.CQRS.Command.Commands
{
    interface ICommandBus
    {
        void Send<T>(T command) where T : ICommand;
    }
}
