using Core.Context;
using Core.Infrastructure.Abstract;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    internal interface IRegionDal : IEntityRepository<TblRegion, EmployeeContext>
    {
    }
}
