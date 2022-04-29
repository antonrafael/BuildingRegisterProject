using BuildingRegisterProject.ViewModel.Commands.Contracts;

namespace BuildingRegisterProject.ViewModel.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
