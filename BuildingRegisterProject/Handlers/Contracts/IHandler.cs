using BuildingRegisterDomain.Commands.Contracts;

namespace BuildingRegisterDomain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
