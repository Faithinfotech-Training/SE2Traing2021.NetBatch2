using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int couresId { get; set; }
        [Required]
        public string courseName { get; set; }
        [Required]
        public string courseDescription { get; set; }
        [Required]
        public int courseDuration { get; set; }
        [Required]
        public string courseStatus { get; set; }
    }
}
