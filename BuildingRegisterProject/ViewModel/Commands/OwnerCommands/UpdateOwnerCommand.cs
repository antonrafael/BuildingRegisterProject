using BuildingRegisterProject.ViewModel.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace BuildingRegisterProject.ViewModel.Commands.OwnerCommands
{
    public class UpdateOwnerCommand : Notifiable, ICommand
    {
        public UpdateOwnerCommand(Guid id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        public Guid Id { get; set; }
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
