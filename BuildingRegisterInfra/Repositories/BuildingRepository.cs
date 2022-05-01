using AppThorus.Domain.Queries;
using BuildingRegisterDomain.Model.Entities;
using BuildingRegisterDomain.Repositories;
using BuildingRegisterInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace BuildingRegisterInfra.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {                
        private readonly BuildingContext _context;

        public BuildingRepository(BuildingContext context)
        {
            _context = context;
        }

        public void Create(Building building)
        {
            _context.Buildings.Add(building);
        }

        public IEnumerable<Building> GetAll()
        {
            return _context.Buildings
                    .AsNoTracking()
                    .Where(BuildingQueries.GetAll());
        }

        public IEnumerable<Building> GetAllFromOwner(Owner owner)
        {
            return _context.Buildings
                    .AsNoTracking()
                    .Where(BuildingQueries.GetAllFromOwner(owner));
        }

        public Building GetById(Guid id)
        {
            return _context.Buildings
                    .FirstOrDefault(BuildingQueries.GetById(id));
        }

        public void Update(Building building)
        {
            _context.Entry(building).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
