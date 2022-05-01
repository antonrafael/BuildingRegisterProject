using BuildingRegisterDomain.Model.Entities;
using System;
using System.Linq.Expressions;

namespace AppThorus.Domain.Queries
{
    public static class OwnerQueries
    {
        public static Expression<Func<Owner,bool>> GetAll()
        {
            return x => x != null;
        }

        public static Expression<Func<Owner, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}
