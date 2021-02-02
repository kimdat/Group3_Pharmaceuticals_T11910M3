using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PharmaceuticalsCompany.Models.Role;
namespace PharmaceuticalsCompany.Services.ManageRole
{
     public interface IManageRole
     {
         IEnumerable<IdentityRole> ListRole();
        Task<EditRoleViewModel> GetRole(string id);
        Task<List<UserRoleViewModel>> ListUserInRole(string id);
        Task<bool> CreateRole(CreateRoleViewModel create);
        Task<bool> EditRole(EditRoleViewModel edit);
        Task<bool> CheckRole(string name);
        Task<string> DeleteRole(string id);
        Task<bool> EditUserInRole(List<UserRoleViewModel> model, string roleId);
     }
}
