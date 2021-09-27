using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Base
{
    public interface IRepository<T>
    {
       
        void Insert(T entity);
        Task InsertAsync(T entity);
        void Delete(T entity);
        Task  DeleteAsync(T entity); //void
        void Add(T entity);
        Task AddAsync(T entity);



        T GetById(System.Guid id);

        Task<T> GetByIdAsync(System.Guid id);

        bool DeleteById(System.Guid id);

        Task<bool> DeleteByIdAsync(System.Guid id);

       IList<T> GetAll();

       Task<IList<T>> GetAllAsync();
    }
}
