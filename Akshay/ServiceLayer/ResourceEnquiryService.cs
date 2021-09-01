using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ResourceEnquiryService:IResourceEnquiry
    {
        private readonly AppDBContext _dbContext;
        private DbSet<ResourceEnquiry> courseDB;

        public ResourceEnquiryService(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
            courseDB = dbContext.Set<ResourceEnquiry>();

        }

        public string AddResourceEnquiry(ResourceEnquiry resourceenquiry)
        {

            this._dbContext.ResourceEnquiries.Add(resourceenquiry);
            this._dbContext.SaveChanges();
            return "ResourceEnquiry Added Successfully";

        }

        public List<ResourceEnquiry> GetAllResourceEnquiries()
        {
            return this._dbContext.ResourceEnquiries.ToList();
        }

        public ResourceEnquiry GetSingleResourceEnquiry(long id)
        {
            return this._dbContext.ResourceEnquiries.Where(x => x.rEnquiryId == id).FirstOrDefault();
        }

        public string RemoveResourceEnquiry(int id)
        {
            try
            {
                var C = this._dbContext.ResourceEnquiries.Find(id);
                this._dbContext.Remove(C);
                this._dbContext.SaveChanges();
                return "Resource Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        

        public string UpdateResourceEnquiry(ResourceEnquiry resource)
        {
         try
         {
          var C = this._dbContext.ResourceEnquiries.Find(resource.rEnquiryId);
            if (C != null)
            {
              C.name= resource.name;
              C.email = resource.email;
              C.phone = resource.phone;
              C.enquiryDate = resource.enquiryDate;
              C.resEnquiryStatus = resource.resEnquiryStatus;
              C.resourceId = resource.resourceId;

              this._dbContext.SaveChanges();
              return "CourseEnquiry Updated Successfully";
            }
            else
              return "No Record Found";
            }
            catch (Exception ex)
            {
               return ex.Message;
            }

        }


        public void updateEnquiryStatus(int id, String status)
        {

            var enquiry = _dbContext.ResourceEnquiries.SingleOrDefault(x => x.rEnquiryId == id);
            PropertyInfo propertyInfo = enquiry.GetType().GetProperty("resEnquiryStatus");
            propertyInfo.SetValue(enquiry, status);
            _dbContext.Entry(enquiry).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }


        public IEnumerable<ResourceEnquiry> getStatusBasedEnquiries(string status)
        {

            return courseDB.Where(enquiry => enquiry.resEnquiryStatus.CompareTo(status) == 0).AsEnumerable();

        }
    }
}
