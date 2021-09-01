using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface ICourseEnquiry
    {
        //AddCourseEnquiry
        string AddCourseEnquiry(CourseEnquiry courseenquiry);

        //GetCourseEnquiries
        List<CourseEnquiry> GetAllCourseEnquiries();

        //GetSingleCourseEnquiry
        CourseEnquiry GetSingleCourseEnquiry(long id);

        //UpdateCourseEnquiry
        string UpdateCourseEnquiry(CourseEnquiry course);

        //Delete CourseEnquiry
        string RemoveCourseEnquiry(int id);

        public IEnumerable<CourseEnquiry> getStatusBasedEnquiries(string status);

    }
}
