using Core.Context;
using Core.Dtos;
using Core.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Concrede
{
    public class ComboFill<T> : IComboFill<T, ComboDto>
         where T : class, new()
    {
        public List<ComboDto> GetCombo(Expression<Func<T, bool>> filter)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
               var value = context.Set<T>().Select(filter).ToList();
               
               return value
            }
        }
    }
}
