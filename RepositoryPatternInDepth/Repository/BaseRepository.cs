using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternInDepth.Repository
{
    public interface IBaseRepository<T>
        where T : class, IBaseEntity
    {
        T Create(T entity);
        T Get(int id);
        void Update(T entity);
        void Delete(int id);
    }


}
