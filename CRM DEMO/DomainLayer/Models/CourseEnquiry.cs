using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class CourseEnquiry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cEnquiryId { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        //[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]

        public string email { get; set; }
        [Required]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public long phone { get; set; }
        [Required]
        public string qualification { get; set; }
        [Required]
        //[Range(0, 25)]
        public string age { get; set; }
        [Required]
        //[Range(60, 100)]
        public int testScore { get; set; }
        [Required]
        public string enquityStatus { get; set; }
        [DataType(DataType.Date)]
        public DateTime enquiryDate { get; set; }

        public int courseId { get; set; }

        [ForeignKey("courseId")]
        public virtual Course Courses { get; set; }

    }
}
