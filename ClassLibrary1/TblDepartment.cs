using System;
using System.Collections.Generic;

#nullable disable

namespace ProffesorManagementSystem.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblProfessors = new HashSet<TblProfessor>();
        }

        public int DeptNo { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<TblProfessor> TblProfessors { get; set; }
    }
}
