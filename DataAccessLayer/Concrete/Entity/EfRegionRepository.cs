using Core.Context;
using Core.Infrastructure.Concrede;
using Core.Models;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Entity
{
    internal class EfRegionRepository : EntityRepositoryBase<TblEmployee, EmployeeContext>, IRegionDal
    {
    }
}
