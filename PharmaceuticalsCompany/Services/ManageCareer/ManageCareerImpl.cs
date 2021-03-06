﻿using Microsoft.AspNetCore.Identity;
using PharmaceuticalsCompany.Data;
using PharmaceuticalsCompany.Models.Career;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalsCompany.Services.ManageCareer
{
    public class ManageCareerImpl : IManageCareer
    {
     
        private ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> _um;
      
        public ManageCareerImpl(ApplicationDbContext context, UserManager<ApplicationUser> um)
        {
           
            this.context = context;
            
            _um = um;

        }

        public  IEnumerable<ApplicationUser> GetAllUser()
        {

            var role = context.Roles.SingleOrDefault(m => m.Name == "Admin");
            var listUser = new List<ApplicationUser>();
            foreach (var item in context.Careers)
            {
                var user = context.Careers.Find(item.Id);
              
                  

                        listUser.Add(user);
                   
               

            }
            foreach (var item in context.UserRoles)
            {
                var user = context.Careers.Find(item.UserId);
                if (item.RoleId == role.Id)
                {

                   listUser.Remove(user);
                }
               

            }
            return listUser;

        }

        public  ApplicationUser GetUser(string id)
        {
            var role = context.Roles.SingleOrDefault(m => m.Name == "Admin");
            ApplicationUser user = _um.FindByIdAsync(id).Result;
            var userRole = context.UserRoles.Where(u => u.UserId.Equals(id));
            foreach(var item in userRole)
            {
                if(item.RoleId==role.Id)
                   return null;
            }
            //if (context.UserRoles.FirstOrDefault(u => u.UserId.Equals(user.Id)
            // && u.RoleId.Equals(role.Id)) != null)
            //return null;
            // else
            return user;
        }

        public IEnumerable<EducationDetails> getEducation(string id)
        {
      
            return context.EducationDetails.Where(e => e.User_id == id).ToList();
        }

        public async Task<ApplicationUser> StatusSendMail(string mail)
        {
            var  user = await _um.FindByEmailAsync(mail);
            if (user != null && user.Status==false)
            {
                user.Status = true;
                context.SaveChanges();
            }

                return user;

           
        }

       
    }
}
