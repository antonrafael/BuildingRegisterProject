using BuildingRegisterProject.Model.Entities;
using System;
using System.Collections.Generic;

namespace BuildingRegisterProject.Repositories
{
    public interface IOwnerRepository
    {
        void Create(Owner owner);
        void Update(Owner owner);
        Owner GetById(Guid id);
        IEnumerable<Owner> GetAll();
    }
}
