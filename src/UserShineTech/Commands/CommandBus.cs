using System;
using System.Collections.Generic;
using System.Text;

namespace UserShineTech.Commands
{
    public class CommandBus : ICommandBus
    {
        private readonly ICommandHandlerFactory _commandHandlerFactory;
        public CommandBus(ICommandHandlerFactory commandHandlerFactory) 
        {
            this._commandHandlerFactory = commandHandlerFactory;
        }
        public void Send<T>(T command) where T : ICommand
        {
            var handler = _commandHandlerFactory.GetHandler<T>();
            if (handler == null) throw new Exception("没有相应的Handler");
            handler.Execute(command);

        }
    }
}
