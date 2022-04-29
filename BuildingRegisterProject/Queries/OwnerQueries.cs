using BuildingRegisterProject.Model.Entities;
using System;
using System.Linq.Expressions;

namespace AppThorus.Domain.Queries
{
    public static class ExpertiseQueries
    {
        public static Expression<Func<Building,bool>> GetAll()
        {
            return x => x != null;
        }
    }
}
