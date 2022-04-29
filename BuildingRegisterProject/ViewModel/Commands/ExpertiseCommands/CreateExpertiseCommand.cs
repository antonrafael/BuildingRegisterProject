using BuildingRegisterProject.ViewModel.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace BuildingRegisterProject.ViewModel.Commands.ExpertiseCommands
{
    public class CreateExpertiseCommand : Notifiable, ICommand
    {
        public CreateExpertiseCommand(string name)
        {
            Name = name;
        }

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
