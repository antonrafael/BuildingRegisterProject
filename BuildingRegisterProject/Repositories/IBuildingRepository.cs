using BuildingRegisterDomain.Model.Entities;
using System;
using System.Collections.Generic;

namespace BuildingRegisterDomain.Repositories
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
