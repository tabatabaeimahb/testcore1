using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Base
{
    public class Repository<T> : object, IRepository<T> where T:Models.Base.Entity
    {
      
        internal Repository(DatabaseContext databaseContext ):base()
        {
            if (databaseContext==null)
            {
                throw new Exception();
            }

            DatabaseContext = databaseContext;

            DbSet = DatabaseContext.Set<T>();
        }
        internal DatabaseContext DatabaseContext { get; }
        internal Microsoft.EntityFrameworkCore.DbSet<T> DbSet { get; }
        public  void Add(T entity)
        {

            DbSet.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
           await DbSet.AddAsync(entity);

        }

        public void Delete(T entity)
        {
            if (entity==null)
            {
                throw new ArgumentNullException(paramName: nameof(entity));
            }
            DbSet.Remove(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(paramName: nameof(entity));
            }
            await Task.Run(() =>
            {
                DbSet.Remove(entity);
            });

        }

        public bool DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
           return DbSet.ToList();
        }

        public async Task<IList<T>> GetAllAsync()
        {
            var getall= await DbSet.ToListAsync();
            return getall;
        
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
