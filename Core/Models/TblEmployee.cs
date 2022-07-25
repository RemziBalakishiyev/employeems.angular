using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Models
{
    public partial class TblEmployee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte? Status { get; set; }
        public int? DepartmentId { get; set; }
        public int? RegionId { get; set; }
        public int? JobId { get; set; }

        public virtual TblDepartment Department { get; set; }
        public virtual TblRegion Region { get; set; }
    }
}
