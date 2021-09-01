using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.DTO
{
    public class UserDTO
    {
        public UserDTO(string fullName, string email, string userName, string role)
        {
            FullName = fullName;
            Email = email;
            UserName = userName;
            Role = role;
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public string Token { get; set; }

        public String Role { get; set; }
    }
}
