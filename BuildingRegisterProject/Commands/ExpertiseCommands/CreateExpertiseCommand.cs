using BuildingRegisterDomain.Commands.Contracts;
using BuildingRegisterDomain.Model.Entities;
using Flunt.Notifications;
using Flunt.Validations;

namespace BuildingRegisterDomain.Commands.ExpertiseCommands
{
    public class CreateExpertiseCommand : Notifiable, ICommand
    {
        public CreateExpertiseCommand(string name, Building building)
        {
            Name = name;
            Building = building;
        }

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
