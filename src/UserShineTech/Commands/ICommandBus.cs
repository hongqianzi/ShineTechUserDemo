using System;
using System.Collections.Generic;
using System.Text;

namespace UserShineTech.Commands
{
    interface ICommandBus
    {
        void Send<T>(T command) where T : ICommand;
    }
}
