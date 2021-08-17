using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage="User Name is Required")]
        public string Username { get; set;}

        [EmailAddress]
        [Required(ErrorMessage = "Email ID is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
    }
}
