using AppThorus.Domain.Queries;
using BuildingRegisterDomain.Model.Entities;
using BuildingRegisterDomain.Repositories;
using BuildingRegisterInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace BuildingRegisterInfra.Repositories
{
    public class ExpertiseRepository : IExpertiseRepository
    {
        private readonly ExpertiseContext _context;

        public ExpertiseRepository(ExpertiseContext context)
        {
            _context = context;
        }
        public void Create(Expertise expertise)
        {
            _context.Expertises.Add(expertise);
        }

        public IEnumerable<Expertise> GetAll()
        {
            return _context.Expertises
                    .AsNoTracking()
                    .Where(ExpertiseQueries.GetAll());
        }

        public Expertise GetById(Guid id)
        {
            return _context.Expertises
                    .FirstOrDefault(ExpertiseQueries.GetById(id));
        }

        public void Update(Expertise expertise)
        {
            _context.Entry(expertise).State = EntityState.Modified;
            _context.SaveChanges();
        }   
    }
}
