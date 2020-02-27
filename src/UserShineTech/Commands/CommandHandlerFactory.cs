using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserShineTech.Commands
{
    public class CommandHandlerFactory : ICommandHandlerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandHandlerFactory(IServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
        }
        public ICommandHandler<T> GetHandler<T>() where T : ICommand
        {
            var types = GetHandlerTypes<T>();

            if (!types.Any()) return null;
            var handler = _serviceProvider.GetService(types.FirstOrDefault()) as ICommandHandler<T>;
            return handler;

        }
        private IEnumerable<Type> GetHandlerTypes<T>() where T : ICommand
        {
            var handlers = typeof(ICommandHandler<>).Assembly.GetExportedTypes()
                .Where(x => x.GetInterfaces()
                    .Any(a => a.IsGenericType && a.GetGenericTypeDefinition() == typeof(ICommandHandler<>)))
                    .Where(h => h.GetInterfaces()
                        .Any(ii => ii.GetGenericArguments()
                            .Any(aa => aa == typeof(T)))).ToList();


            return handlers;
        }

    }
}
