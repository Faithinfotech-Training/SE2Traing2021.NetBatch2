using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface ICourse
    {
        //AddCourse
        string AddCourse(Course course);

        //GetCourses
        List<Course> GetAllCourses();

        //GetSingleCourse
        Course GetSingleCourse(long id);

        //UpdateCourse
        string UpdateCourse(Course course);

        //Delete Course
        string RemoveCourse(int id);

    }
}
