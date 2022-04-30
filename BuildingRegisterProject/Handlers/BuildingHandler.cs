using BuildingRegisterProject.Model.Entities;
using BuildingRegisterProject.Repositories;
using BuildingRegisterProject.Commands;
using BuildingRegisterProject.Commands.BuildingCommands;
using BuildingRegisterProject.Commands.Contracts;
using BuildingRegisterProject.Handlers.Contracts;
using Flunt.Notifications;

namespace BuildingRegisterProject.Handlers
{
    public class BuildingHandler :
        Notifiable,
        IHandler<CreateBuildingCommand>, 
        IHandler<UpdateBuildingCommand>,
        IHandler<AddExpertiseCommand>,
        IHandler<RemoveExpertiseCommand>
    {
        private readonly IBuildingRepository _repository;

        public BuildingHandler(IBuildingRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateBuildingCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    "Is something wrong with your Building",
                    command.Notifications);

            var building = new Building(command.Name, command.Address, command.BuildingOwner);

            _repository.Create(building);

            return new GenericCommandResult(
                    true,
                    "Building created",
                    building);
        }

        public ICommandResult Handle(UpdateBuildingCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    "Is something wrong with your Building",
                    command.Notifications);

            var building = _repository.GetById(command.Id);

            building.Update(command.Name, command.Address);

            _repository.Update(building);

            return new GenericCommandResult(
                    true,
                    "Building Updated",
                    building);
        }

        public ICommandResult Handle(AddExpertiseCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    "Building not valid",
                    command.Notifications);

            var building = _repository.GetById(command.Id);

            building.AddExpertise(command.Expertise);

            _repository.Update(building);

            return new GenericCommandResult(
                    true,
                    "Building Updated",
                    building);
        }

        public ICommandResult Handle(RemoveExpertiseCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    "Building not valid",
                    command.Notifications);

            var building = _repository.GetById(command.Id);

            building.RemoveExpertise(command.Expertise);

            _repository.Update(building);

            return new GenericCommandResult(
                    true,
                    "Building Updated",
                    building);
        }
    }
}
