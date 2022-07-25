using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Abstract
{
    public interface IEntityRepository<T, TContext>
        where T : class,new()
        where TContext : DbContext
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GetT(Expression<Func<T,bool>> filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
