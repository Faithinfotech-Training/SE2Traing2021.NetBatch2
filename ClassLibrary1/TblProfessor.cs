using System;
using System.Collections.Generic;

#nullable disable

namespace ProffesorManagementSystem.Models
{
    public partial class TblProfessor
    {
        public int ProfessorId { get; set; }
        public int ManagerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Gender { get; set; }
        public int? DeptNo { get; set; }

        public virtual TblDepartment DeptNoNavigation { get; set; }

       
    }
}
