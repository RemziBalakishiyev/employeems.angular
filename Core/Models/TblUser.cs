using System;
using System.Collections.Generic;

#nullable disable

namespace Core.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte? Status { get; set; }
    }
}
