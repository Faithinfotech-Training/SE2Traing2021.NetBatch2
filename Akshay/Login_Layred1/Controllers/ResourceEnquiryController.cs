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
    public class ResourceEnquiryController : ControllerBase
    {
        private readonly IResourceEnquiry _resource;

        private readonly ResourceEnquiryService _courseService;
        public ResourceEnquiryController(IResourceEnquiry resource, ResourceEnquiryService courseService)
        {
            this._resource = resource;
            this._courseService = courseService;

        }

        //GetAllResourceEnquiries
        [HttpGet("getAllResourceEnquiries")]
        public IActionResult GetAllResourceEnquiries()
        {
            var response = this._resource.GetAllResourceEnquiries();
            return Ok(response);
        }

        //GetSingleRecord
        [HttpGet("get/{id:int}")]
        public IActionResult GetSingleRecord(long id)
        {
            return Ok(this._resource.GetSingleResourceEnquiry(id));
        }

        //AddCourse
        [HttpPost("AddResourceEnquiry")]
        public IActionResult AddResourceEnquiry(ResourceEnquiry resourceenquiry)
        {
            return Ok(this._resource.AddResourceEnquiry(resourceenquiry));
        }

        //RemoveResource
        [HttpDelete("DeleteResourceEnquiry")]
        public IActionResult RemoveResourceEnquiry(int id)
        {
            return Ok(this._resource.RemoveResourceEnquiry(id));
        }

        //UpdateCourse
        [HttpPut("UpdateResourceEnquiry")]
        public IActionResult UpdateResourceEnquiry(ResourceEnquiry course)
       {
         return Ok(this._resource.UpdateResourceEnquiry(course));
        }

        [HttpPut("{id}/status/{Status}")]
        public void updateEnquiryStatus(int id, String Status)
        {
            _courseService.updateEnquiryStatus(id, Status);
        }


        [HttpGet("status/{Status}")]
        public IActionResult GetStatusBasedEnquiries(String Status)
        {
            return Ok(_courseService.getStatusBasedEnquiries(Status));
        }
    }
}
