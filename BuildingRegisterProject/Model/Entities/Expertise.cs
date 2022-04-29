
namespace BuildingRegisterProject.Model.Entities
{
    public class Expertise : Entity
    {
        public Expertise(string Name)
        {
            Name = Name;
        }
        public string Name { get; private set; }

        public void Update(string name)
        {
            Name = name;
        }
    }
}
