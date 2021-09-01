using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Resource
    {
        [Key]
        public int resourceId { get; set; }
        [Required]
        public string resourceName { get; set; }
        [Required]
        public string resourceStatus { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime resRecordDate { get; set; }
        [Required]
        public string resourceType { get; set; }
    }
}
