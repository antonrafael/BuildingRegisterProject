using BuildingRegisterDomain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace BuildingRegisterDomain.Commands.BuildingCommands
{
    public class UpdateBuildingCommand : Notifiable, ICommand
    {
        public UpdateBuildingCommand(Guid id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public Guid Id { get; }
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
