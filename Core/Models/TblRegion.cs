using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Models
{
    public partial class TblRegion
    {
        public TblRegion()
        {
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int RegionId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
