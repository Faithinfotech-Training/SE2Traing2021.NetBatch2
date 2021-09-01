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
    public class CourseEnquiryService : ICourseEnquiry
    {
        private readonly AppDBContext _dbContext;
        private DbSet<CourseEnquiry> courseDB;
        public CourseEnquiryService(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
            courseDB = dbContext.Set<CourseEnquiry>();
        }

        public string AddCourseEnquiry(CourseEnquiry courseenquiry)
        {
            
                this._dbContext.CourseEnquiries.Add(courseenquiry);
                this._dbContext.SaveChanges();
                return "CourseEnquiry Added Successfully";
            
        }

        public List<CourseEnquiry> GetAllCourseEnquiries()
        {
            return this._dbContext.CourseEnquiries.ToList();
        }

        public CourseEnquiry GetSingleCourseEnquiry(long id)
        {
            return this._dbContext.CourseEnquiries.Where(x => x.cEnquiryId == id).FirstOrDefault();
        }

        public string RemoveCourseEnquiry(int id)
        {
            try
            {
                var C = this._dbContext.CourseEnquiries.Find(id);
                this._dbContext.Remove(C);
                this._dbContext.SaveChanges();
                return "Course Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateCourseEnquiry(CourseEnquiry course)
        {
            try
            {
                var C = this._dbContext.CourseEnquiries.Find(course.cEnquiryId);
                if (C != null)
                {
                    C.enquityStatus = course.enquityStatus;
                    C.courseId = course.courseId;
                    C.enquityStatus = course.enquityStatus;
                    C.name = course.name;
                    C.age = course.age;
                    C.phone = course.phone;
                    C.qualification = course.qualification;
                    C.testScore = course.testScore;
                 



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

            var enquiry = _dbContext.CourseEnquiries.SingleOrDefault(x => x.cEnquiryId == id);
            PropertyInfo propertyInfo = enquiry.GetType().GetProperty("enquityStatus");
            propertyInfo.SetValue(enquiry, status);
            _dbContext.Entry(enquiry).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public IEnumerable<CourseEnquiry> getStatusBasedEnquiries(string status)
        {

            return courseDB.Where(enquiry => enquiry.enquityStatus.CompareTo(status) == 0).AsEnumerable();

        }
    }
}
