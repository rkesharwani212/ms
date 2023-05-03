using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticateService.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
