using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IResource
    {
        //AddResource
        string AddResource(Resource resource);

        //GetResources
        List<Resource> GetAllResources();

        //GetSingleResource
        Resource GetSingleResource(long id);

        //UpdateResource
        string UpdateResource(Resource resource);

        //DeleteResource
        string RemoveResource(int id);

    }
}
