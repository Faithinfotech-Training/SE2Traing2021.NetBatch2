using DomainLayer.Models;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CourseService : ICourse
    {
        private readonly AppDBContext _dbContext;
        public CourseService(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
        }
        
        public string AddCourse(Course course)
        {
            try
            {
                this._dbContext.Courses.Add(course);
                this._dbContext.SaveChanges();
                return "Course Added Successfully";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Course> GetAllCourses()
        {
            return this._dbContext.Courses.ToList();
        }

        public Course GetSingleCourse(long id)
        {
            return this._dbContext.Courses.Where(x => x.couresId == id).FirstOrDefault();
        }

        public string RemoveCourse(int id)
        {
            try
            {
                var C = this._dbContext.Courses.Find(id);
                this._dbContext.Remove(C);
                this._dbContext.SaveChanges();
                return "Course Deleted Successfully";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateCourse(Course course)
        {
            try
            {
                var C = this._dbContext.Courses.Find(course.couresId);
                if (C != null)
                {
                    C.courseName = course.courseName;
                    C.courseDescription = course.courseDescription;
                    C.courseDuration = course.courseDuration;
                    C.courseStatus = course.courseStatus;
                  
                    this._dbContext.SaveChanges();
                    return "Course Updated Successfully";
                }
                else
                    return "No Record Found";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
