using BuildingRegisterProject.ViewModel.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace BuildingRegisterProject.ViewModel.Commands.ExpertiseCommands
{
    public class UpdateExpertiseCommand : Notifiable, ICommand
    {
        public UpdateExpertiseCommand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Validate()
        {
            AddNotifications(
               new Contract()
                   .Requires()
                   .HasMinLen(Name, 3, "Name", "The name is to short")
               );
        }
    }
}
