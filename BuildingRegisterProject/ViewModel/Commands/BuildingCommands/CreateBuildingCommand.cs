using BuildingRegisterProject.ViewModel.Commands.Contracts;
using BuildingRegisterProject.Model.Entities;
using Flunt.Notifications;
using Flunt.Validations;

namespace BuildingRegisterProject.ViewModel.Commands.BuildingCommands
{
    public class CreateBuildingCommand : Notifiable, ICommand
    {
        public CreateBuildingCommand(string name, string address, Owner buildingOwner)
        {
            Name = name;
            Address = address;
            BuildingOwner = buildingOwner;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public Owner BuildingOwner { get; set; }        

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(Name, 3, "Name", "The name is to short")
                    .HasMinLen(Address, 6, "Address", "The address is to short")
                    .IsNotNullOrEmpty(BuildingOwner.Name, "Building Owner", "The owner field cannot be null")
                );
        }
    }
}
