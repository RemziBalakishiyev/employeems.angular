using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Abstract
{
    public interface IComboFill<T,ComboDto>
         where T : class, new()
       
    {
        List<ComboDto> GetCombo(Expression<Func<T, bool>> filter);
    }
}
