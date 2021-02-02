using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PharmaceuticalsCompany.Models.Career;
using PharmaceuticalsCompany.Models.Role;

using Microsoft.EntityFrameworkCore;

namespace PharmaceuticalsCompany.Services.ManageRole
{
    public class ManageRoleImpl : IManageRole
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        public ManageRoleImpl(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {

            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public async Task<bool> CheckRole(string name)
        {
            if (await roleManager.RoleExistsAsync(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  async Task<bool> CreateRole(CreateRoleViewModel create)
        {
          
            IdentityRole identityRole = new IdentityRole
            {
                Name =create.RoleName
            };
            IdentityResult result = await roleManager.CreateAsync(identityRole);
            return true;
        }

        public async Task<string> DeleteRole(string id)
        {
            
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
                return null;
            else
            {
                foreach (var user in userManager.Users)
                {
                   
                     if (await userManager.IsInRoleAsync(user, role.Name))
                     {

                         return "haveUser";
                          
                     }
                   
                 }
                var result = await roleManager.DeleteAsync(role);
                if(result.Succeeded)
                {
                    return "success";
                }
                else
                {
                    return "error";
                }
            }
        }

        public async Task<bool> EditRole(EditRoleViewModel edit)
        {
            var role = await roleManager.FindByIdAsync(edit.Id);
            if (role == null)
            {
                return false;
            }
            else
            {
                role.Name = edit.RoleName;
                var result = await roleManager.UpdateAsync(role);
                return true;
               
               

            }

           
        }

        public async Task<bool> EditUserInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);
          
            foreach (var item in model)
            {
                var user = await userManager.FindByIdAsync(item.UserId);
                IdentityResult result = null;
                result = await userManager.AddToRoleAsync(user, role.Name);

                if (item.IsSelected=="true"&& !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                  
                }
                else if (item.IsSelected!="true" && (await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);

                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    continue;
                }
                if (result.Errors.Count()>0)
                    return false;
            }
            return true;
        }

        public async Task<EditRoleViewModel> GetRole(string id)
        {
            var role =  roleManager.FindByIdAsync(id).Result;
            if (role == null)
                return null;
            var model = new EditRoleViewModel
            {
                Id=role.Id,
                RoleName=role.Name
                
            };
            
        
            foreach (var user in userManager.Users)
            {
           
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.ListUsers.Add(user.Email);
                }

            }
            return model;

        }

      

        public IEnumerable<IdentityRole> ListRole()
        {

            return  roleManager.Roles.Where(m => m.Name != "Admin"); 
        }

        public async Task<List<UserRoleViewModel>> ListUserInRole(string id)
        {
            var model = new List<UserRoleViewModel>();
            var role = await roleManager.FindByIdAsync(id);
            foreach (var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Email = user.Email

                };
                if(role!=null)
                {
                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        userRoleViewModel.IsSelected = "true";
                    }
                    else
                    {
                        userRoleViewModel.IsSelected ="false";
                    }

                }
               
                model.Add(userRoleViewModel);
            }
            return model;
        }
    }
}
