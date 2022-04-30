using System.Collections.Generic;

namespace BuildingRegisterProject.Model.Entities
{
    public class Building : Entity
    {
        public Building(string name, string address, Owner owner)
        {
            Name = name;
            Address = address;
            BuildingOwner = owner;
            Expertises = new List<Expertise>();
        }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public Owner BuildingOwner { get; private set; }
        public List<Expertise> Expertises { get; private set; }

        public void AddExpertise(Expertise expertise)
        {
            Expertises.Add(expertise);
        }

        public void RemoveExpertise(Expertise expertise)
        {
            Expertises.Remove(expertise);
        }

        public void Update(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
