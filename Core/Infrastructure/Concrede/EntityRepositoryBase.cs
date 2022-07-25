using Core.Context;
using Core.Infrastructure.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Concrede
{
    public class EntityRepositoryBase<T,TContext> : IEntityRepository<T, TContext>
        where T : class,new()
        where TContext:DbContext
    {
        public void Add(T entity)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using EmployeeContext context = new EmployeeContext();
                return filter==null?
                    context.Set<T>().ToList():
                    context.Set<T>().Where(filter).ToList();

        }

        public T GetT(Expression<Func<T, bool>> filter = null)
        {
            using EmployeeContext context = new EmployeeContext();
                 return filter == null ?
                       context.Set<T>().FirstOrDefault() :
                       context.Set<T>().Where(filter).FirstOrDefault();
                    
        }

        public void Update(T entity)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
