using System;
using System.Collections.Generic;

#nullable disable

namespace CRM.Models
{
    public partial class CourseEnquiry
    {
        public int CourseEnquiryId { get; set; }
        public string CFullName { get; set; }
        public string CEmail { get; set; }
        public string CPhoneNumber { get; set; }
        public DateTime Dob { get; set; }
        public string Qualification { get; set; }
        public int TestScore { get; set; }
        public string CStatus { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
