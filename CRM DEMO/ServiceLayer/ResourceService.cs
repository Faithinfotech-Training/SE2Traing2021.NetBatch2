using DomainLayer.Models;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ResourceService : IResource
    {
        private readonly AppDBContext _dbContext;
        public ResourceService(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public string AddResource(Resource resource)
        {
            try
            {
                this._dbContext.Resources.Add(resource);
                this._dbContext.SaveChanges();
                return "Resource Added Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Resource> GetAllResources()
        {
            return this._dbContext.Resources.ToList();
        }

        public Resource GetSingleResource(long id)
        {
            return this._dbContext.Resources.Where(x => x.resourceId == id).FirstOrDefault();
        }

        public string RemoveResource(int id)
        {
            try
            {
                var C = this._dbContext.Resources.Find(id);
                this._dbContext.Remove(C);
                this._dbContext.SaveChanges();
                return "Resource Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateResource(Resource resource)
        {
            try
            {
                var C = this._dbContext.Resources.Find(resource.resourceId);
                if (C != null)
                {
                    C.resourceName = resource.resourceName;
                    C.resourceStatus = resource.resourceStatus;

                    C.resourceType = resource.resourceType;
                    C.resRecordDate = resource.resRecordDate;
                    this._dbContext.SaveChanges();
                    return "Resource Updated Successfully";
                }
                else
                    return "No Record Found";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
