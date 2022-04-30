using BuildingRegisterProject.Model.Entities;
using BuildingRegisterProject.Repositories;
using BuildingRegisterProject.Commands;
using BuildingRegisterProject.Commands.Contracts;
using BuildingRegisterProject.Commands.OwnerCommands;
using BuildingRegisterProject.Handlers.Contracts;
using Flunt.Notifications;

namespace BuildingRegisterProject.Handlers
{
    public class OwnerHandler : 
        Notifiable,
        IHandler<CreateOwnerCommand>, 
        IHandler<UpdateOwnerCommand>
    {
        private readonly IOwnerRepository _repository;

        public OwnerHandler(IOwnerRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateOwnerCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    "Is something wrong with your Owner",
                    command.Notifications);

            var owner = new Owner(command.Name, command.Address);

            _repository.Create(owner);

            return new GenericCommandResult(
                    true,
                    "Owner created",
                    owner);
        }

        public ICommandResult Handle(UpdateOwnerCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    "Is something wrong with your Owner",
                    command.Notifications);

            var owner = _repository.GetById(command.Id);

            owner.Update(command.Name, command.Address);

            _repository.Update(owner);

            return new GenericCommandResult(
                    true,
                    "Owner Updated",
                    owner);
        }
    }
}
