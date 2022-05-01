
namespace BuildingRegisterDomain.Model.Entities
{
    public class Expertise : Entity
    {
        public Expertise(string name, Building building)
        {            
            Name = name;
            Building = building;
        }
        public string Name { get; private set; }
        public Building Building { get; set; }
        public void Update(string name)
        {
            Name = name;
        }
    }
}
