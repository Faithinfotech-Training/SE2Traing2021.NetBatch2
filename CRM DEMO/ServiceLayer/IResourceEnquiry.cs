using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IResourceEnquiry
    {
        //AddResourceEnquiry
        string AddResourceEnquiry(ResourceEnquiry resourceenquiry);

        //GetResourceEnquiries
        List<ResourceEnquiry> GetAllResourceEnquiries();

        //GetSingleResourceEnquiry
        ResourceEnquiry GetSingleResourceEnquiry(long id);

        //UpdateResourceEnquiry
        string UpdateResourceEnquiry(ResourceEnquiry resource);

        //Delete ResourceEnquiry
        string RemoveResourceEnquiry(int id);

        public IEnumerable<ResourceEnquiry> getStatusBasedEnquiries(string status);


    }
}
