using BuildingRegisterProject.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace BuildingRegisterProject.Commands.OwnerCommands
{
    public class CreateOwnerCommand : Notifiable, ICommand
    {
        public CreateOwnerCommand(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }

        public void Validate()
        {
            AddNotifications(
               new Contract()
                   .Requires()
                   .HasMinLen(Name, 3, "Name", "The name is to short")
                   .HasMinLen(Address, 6, "Address", "The address is to short")
               );
        }
    }
}
