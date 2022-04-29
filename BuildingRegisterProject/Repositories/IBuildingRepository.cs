using BuildingRegisterProject.Model.Entities;
using System;
using System.Collections.Generic;

namespace BuildingRegisterProject.Repositories
{
    public interface IBuildingRepository
    {
        void Create(Building building);
        void Update(Building building);
        Building GetById(Guid id);
        IEnumerable<Building> GetAll();
        IEnumerable<Building> GetAllFromOwner(Owner owner);
    }
}
