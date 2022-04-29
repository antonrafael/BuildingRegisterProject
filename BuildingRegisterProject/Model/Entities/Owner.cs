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

        public void Update(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
