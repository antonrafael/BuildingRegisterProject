using BuildingRegisterProject.Model.Entities;
using System;
using System.Collections.Generic;

namespace BuildingRegisterProject.Repositories
{
    public interface IExpertiseRepository
    {
        void Create(Expertise expertise);
        void Update(Expertise expertise);
        Expertise GetById(Guid id);
        IEnumerable<Expertise> GetAll();
    }
}
