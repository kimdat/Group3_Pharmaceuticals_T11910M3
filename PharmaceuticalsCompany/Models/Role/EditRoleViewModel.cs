using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalsCompany.Models.Role
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            ListUsers = new List<string>();
        }
        public string Id { get; set; }
        public string RoleName { get; set; }
        public List<string> ListUsers { get; set; }
    }
}
