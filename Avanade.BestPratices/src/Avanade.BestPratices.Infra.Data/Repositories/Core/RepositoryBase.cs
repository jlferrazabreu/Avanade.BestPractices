using Avanade.BestPratices.Infra.Core.Entities;
using Avanade.BestPratices.Infra.Core.Entities.Interfaces;
using Avanade.BestPratices.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Avanade.BestPratices.Infra.Data.Repositories.Core
{
    public class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        private readonly EntityContext db;

        public RepositoryBase(EntityContext _db )
        {
            db = _db;
        }

        public Task AddAsync(T entity)
        {
            return db.Set<T>()
                .AddAsync(entity)
                .AsTask();
        }

        public Task AddRangeAsync(List<T> entities)
        {
            return db.Set<T>()
                .AddRangeAsync();
        }

        public Task<List<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
