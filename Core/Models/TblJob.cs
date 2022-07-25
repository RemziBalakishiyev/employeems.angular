using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Models
{
    public partial class TblJob
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public double? JobSalary { get; set; }
        public int? DepartmentId { get; set; }

        public virtual TblDepartment Department { get; set; }
    }
}
