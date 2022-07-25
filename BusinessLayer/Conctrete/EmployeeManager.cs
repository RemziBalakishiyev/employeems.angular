using BusinessLayer.Abstract;
using Core.Models;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conctrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)//EfEmployeeRpe 
        {
            this.employeeDal = employeeDal;
        }
        public void Add(TblEmployee entity)
        {
            employeeDal.Add(entity);    
        }

        public void Delete(TblEmployee entity)
        {
           employeeDal.Delete(entity);
        }

        public List<TblEmployee> GetAll(System.Linq.Expressions.Expression<Func<TblEmployee, bool>> filter = null)
        {
           return employeeDal.GetAll(filter);
        }

        public TblEmployee GetT(System.Linq.Expressions.Expression<Func<TblEmployee, bool>> filter = null)
        {
            return employeeDal.GetT(filter);
        }

        public void Update(TblEmployee entity)
        {
            employeeDal.Update(entity);
        }
    }
}
