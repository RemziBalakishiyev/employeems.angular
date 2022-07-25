using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblEmployees = new HashSet<TblEmployee>();
            TblJobs = new HashSet<TblJob>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
        public virtual ICollection<TblJob> TblJobs { get; set; }
    }
}
