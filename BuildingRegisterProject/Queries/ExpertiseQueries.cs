using BuildingRegisterDomain.Model.Entities;
using System;
using System.Linq.Expressions;

namespace AppThorus.Domain.Queries
{
    public static class ExpertiseQueries
    {
        public static Expression<Func<Expertise,bool>> GetAll()
        {
            return x => x != null;
        }

        public static Expression<Func<Expertise, bool>> GetAllFromBuilding(Building building)
        {
            return x => x.Building == building;
        }

        public static Expression<Func<Expertise, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}
