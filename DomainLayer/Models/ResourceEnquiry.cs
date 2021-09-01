using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ResourceEnquiry
    {
        [Key]
        public int rEnquiryId { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        //[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string email { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public long phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime enquiryDate { get; set; }


        public int resourceId { get; set; }

        public string resEnquiryStatus { get; set; }

        [ForeignKey("resourceId")]
        public virtual Resource Resources { get; set; }

    }
}
