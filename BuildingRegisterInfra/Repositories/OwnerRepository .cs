using AppThorus.Domain.Queries;
using BuildingRegisterDomain.Model.Entities;
using BuildingRegisterDomain.Repositories;
using BuildingRegisterInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace BuildingRegisterInfra.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly OwnerContext _context;

        public OwnerRepository(OwnerContext context)
        {
            _context = context;
        }
        public void Create(Owner owner)
        {
            _context.Owners.Add(owner);
        }

        public IEnumerable<Owner> GetAll()
        {
            return _context.Owners
                    .AsNoTracking()
                    .Where(OwnerQueries.GetAll());
        }

        public Owner GetById(Guid id)
        {
            return _context.Owners
                    .FirstOrDefault(OwnerQueries.GetById(id));
        }

        public void Update(Owner owner)
        {
            _context.Entry(owner).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
