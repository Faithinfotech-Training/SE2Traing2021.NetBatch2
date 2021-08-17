using System;
using System.Collections.Generic;

#nullable disable

namespace CRM.Models
{
    public partial class ResourceEnquiry
    {
        public int ResourceEnquiryId { get; set; }
        public string RFullName { get; set; }
        public string REmail { get; set; }
        public string RPhoneNumber { get; set; }
        public bool RStatus { get; set; }
        public int ResourceId { get; set; }

        public virtual Resource Resource { get; set; }
    }
}
