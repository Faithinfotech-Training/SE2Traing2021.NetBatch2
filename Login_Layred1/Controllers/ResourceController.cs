using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Layred1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ResourceController : ControllerBase
    {
        private readonly IResource _resource;
        public ResourceController(IResource resource)
        {
            this._resource = resource;
        }

        //GetAllResource
        [HttpGet("getAllResources")]
        public IActionResult GetAllResources()
        {
            var response = this._resource.GetAllResources();
            return Ok(response);
        }

        //GetSingleRecord
        [HttpGet("get/{id:int}")]
        public IActionResult GetSingleRecord(long id)
        {
            return Ok(this._resource.GetSingleResource(id));
        }

        //AddResource
        [HttpPost("AddResource")]
        public IActionResult AddResource(Resource resource)
        {
            return Ok(this._resource.AddResource(resource));
        }

        //RemoveResource
        [HttpDelete("DeleteResource")]
        public IActionResult RemoveResource(int id)
        {
            return Ok(this._resource.RemoveResource(id));
        }

        //UpdateResource
        [HttpPut("UpdateResource")]
        public IActionResult UpdateResource(Resource resource)
        {
            return Ok(this._resource.UpdateResource(resource));
        }
    }
}
