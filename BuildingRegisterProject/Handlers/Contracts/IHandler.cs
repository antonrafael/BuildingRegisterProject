using BuildingRegisterProject.Commands.Contracts;

namespace BuildingRegisterProject.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
