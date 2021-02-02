using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalsCompany.Models.Role
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string  UserName { get; set; }
        public string Email { get; set; }
        public string IsSelected { get; set; }
    }
}
