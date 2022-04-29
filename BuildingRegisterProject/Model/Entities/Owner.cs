namespace BuildingRegisterProject.Model.Entities
{
    public class Owner : Entity
    {
        public Owner(string name, string adress)
        {
            Name = name;
            Address = adress;
        }
        public string Name { get; private set; }
        public string Address { get; private set; }
    }
}
