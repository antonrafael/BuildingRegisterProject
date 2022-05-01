using BuildingRegisterDomain.Commands.Contracts;
using BuildingRegisterDomain.Model.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace BuildingRegisterDomain.Commands.ExpertiseCommands
{
    public class UpdateExpertiseCommand : Notifiable, ICommand
    {
        public UpdateExpertiseCommand(Guid id, string name, Building building)
        {
            Id = id;
            Name = name;
            Building = building;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Building Building { get; set; }

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
