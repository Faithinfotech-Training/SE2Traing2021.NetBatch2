using System;
using System.Collections.Generic;

#nullable disable

namespace CRM.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseEnquiries = new HashSet<CourseEnquiry>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDesc { get; set; }
        public decimal CoursePrice { get; set; }
        public int CourseDuration { get; set; }
        public bool CourseAvailability { get; set; }

        public virtual ICollection<CourseEnquiry> CourseEnquiries { get; set; }
    }
}
