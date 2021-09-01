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
    public class CourseController : ControllerBase
    {
        private readonly ICourse _course;
        public CourseController(ICourse course)
        {
            this._course = course;
        }

        //GetAllCourse
        [HttpGet("getAllCourses")]
        public IActionResult GetAllCourses()
        {
            var response = this._course.GetAllCourses();
            return Ok(response);
        }

        //GetSingleRecord
        [HttpGet("get/{id:int}")]
        public IActionResult GetSingleRecord(long id)
        {
            return Ok(this._course.GetSingleCourse(id));
        }

        //AddCourse
        [HttpPost("AddCourse")]
        public IActionResult AddCourse(Course course)
        {
            return Ok(this._course.AddCourse(course));
        }

        //RemoveCourse
        [HttpDelete("DeleteCourse")]
        public IActionResult RemoveCourse(int id)
        {
            return Ok(this._course.RemoveCourse(id));
        }

        //UpdateCourse
        [HttpPut("UpdateCourse")]
        public IActionResult UpdateCourse(Course course)
        {
            return Ok(this._course.UpdateCourse(course));
        }
    }
}
