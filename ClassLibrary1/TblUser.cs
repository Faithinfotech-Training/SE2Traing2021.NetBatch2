using System;
using System.Collections.Generic;

#nullable disable

namespace ProffesorManagementSystem.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }

        public virtual TblRole Role { get; set; }
    }
}
