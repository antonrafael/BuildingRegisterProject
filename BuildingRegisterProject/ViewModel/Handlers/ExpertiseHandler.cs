using BuildingRegisterProject.Model.Entities;
using BuildingRegisterProject.Repositories;
using BuildingRegisterProject.ViewModel.Commands;
using BuildingRegisterProject.ViewModel.Commands.Contracts;
using BuildingRegisterProject.ViewModel.Commands.ExpertiseCommands;
using BuildingRegisterProject.ViewModel.Handlers.Contracts;
using Flunt.Notifications;

namespace BuildingRegisterProject.ViewModel.Handlers
{
    public class ExpertiseHandler : 
        Notifiable,
        IHandler<CreateExpertiseCommand>, 
        IHandler<UpdateExpertiseCommand>
    {
        private readonly IExpertiseRepository _repository;

        public ExpertiseHandler(IExpertiseRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateExpertiseCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    "Is something wrong with your Expertise",
                    command.Notifications);

            var expertise = new Expertise(command.Name);

            _repository.Create(expertise);

            return new GenericCommandResult(
                    true,
                    "Expertise created",
                    expertise);
        }

        public ICommandResult Handle(UpdateExpertiseCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(
                    false,
                    "Is something wrong with your Expertise",
                    command.Notifications);

            var expertise = _repository.GetById(command.Id);

            expertise.Update(command.Name);

            _repository.Update(expertise);

            return new GenericCommandResult(
                    true,
                    "Expertise Updated",
                    expertise);
        }
    }
}
