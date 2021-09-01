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
    public class CourseEnquiryController : ControllerBase
    {
        private readonly ICourseEnquiry _course;
        private readonly CourseEnquiryService _courseService;

        public CourseEnquiryController(ICourseEnquiry course, CourseEnquiryService courseService)
        {
            this._course = course;
            this._courseService = courseService;
        }

        //GetAllCourseEnquiries
        [HttpGet("getAllCourseEnquiries")]
        public IActionResult GetAllCourseEnquiries()
        {
            var response = this._course.GetAllCourseEnquiries();
            return Ok(response);
        }

        //GetSingleRecord
        [HttpGet("get/{id:int}")]
        public IActionResult GetSingleRecord(long id)
        {
            return Ok(this._course.GetSingleCourseEnquiry(id));
        }

        //AddCourse
        [HttpPost("AddCourseEnquiry")]
        public IActionResult AddCourseEnquiry(CourseEnquiry courseenquiry)
        {
            return Ok(this._course.AddCourseEnquiry(courseenquiry));
        }

        //RemoveCourse
        [HttpDelete("DeleteCourseEnquiry")]
        public IActionResult RemoveCourseEnquiry(int id)
        {
            return Ok(this._course.RemoveCourseEnquiry(id));
        }

        //UpdateCourse
        [HttpPut("UpdateCourseEnquiry")]
        public IActionResult UpdateCourseEnquiry(CourseEnquiry course)
        {
            return Ok(this._course.UpdateCourseEnquiry(course));
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
