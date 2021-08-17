using System;
using System.Collections.Generic;

#nullable disable

namespace CRM.Models
{
    public partial class Resource
    {
        public Resource()
        {
            ResourceEnquiries = new HashSet<ResourceEnquiry>();
        }

        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceDesc { get; set; }
        public decimal ResourcePrice { get; set; }

        public virtual ICollection<ResourceEnquiry> ResourceEnquiries { get; set; }
    }
}
