using BuildingRegisterDomain.Model.Entities;
using System;
using System.Linq.Expressions;

namespace AppThorus.Domain.Queries
{
    public static class BuildingQueries
    {
        public static Expression<Func<Building,bool>> GetAll()
        {
            return x => x != null;
        }
        public static Expression<Func<Building, bool>> GetAllFromOwner(Owner owner)
        {
            return x => x.BuildingOwner == owner;
        }

        public static Expression<Func<Building, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }

    }
}
