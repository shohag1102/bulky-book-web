using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category
        IEnumerable<T> GetAll();

        //for single data
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Remove(T  entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
