using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; } = 0;
        public String Page { get; set; }
        public DateTime Day { get; set; } = DateTime.Now;
        public int Views { get; set; } = 1;
    }
}
