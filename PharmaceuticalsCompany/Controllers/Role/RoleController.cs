using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmaceuticalsCompany.Models.Role;
using PharmaceuticalsCompany.Services.ManageRole;
using ReflectionIT.Mvc.Paging;

namespace PharmaceuticalsCompany.Controllers.Role
{
 [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private IManageRole services;
        public RoleController(IManageRole services)
        {


            this.services = services;
        }
        [Route("Admin/Role")]

        public  IActionResult Index(int page=1)
        {
            var list = services.ListRole();
            var model =  PagingList.Create(list,1,page);

       
            if (TempData.ContainsKey("EditRole"))
            {
                ViewBag.EditRole = TempData["EditRole"];
            }
            if (TempData.ContainsKey("Error"))
            {
                ViewBag.Error = TempData["Error"];
            }
          
            return View("~/Views/Admin/Role/Index.cshtml",model);
        }
     
        [Route("Admin/Role/Create")]
         
        [HttpGet]
        public IActionResult CreateRole()
        {
            if (TempData.ContainsKey("RoleExist"))
            {
                ViewBag.RoleExist = TempData["RoleExist"];
            }
            return View("~/Views/Admin/Role/Create.cshtml");
        }
        [Route("Admin/Role/Create")]

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            // bool checkRole = await services.CheckRole(model.RoleName);
            //if (checkRole == true)
            // return RedirectToAction("Index", "role");
            if(model.RoleName.ToLower()=="admin")
            {
                TempData["RoleExist"] = "Role Admin can not add";
                return RedirectToRoute(new { action = "CreateRole", controller = "Role" });
            }
            if (services.CheckRole(model.RoleName).Result == true)
            {
                TempData["RoleExist"] = "this role has exist";
                return RedirectToRoute(new { action = "CreateRole", controller = "Role" });
            }
            bool result = await services.CreateRole(model);
           
            if (result == true)
            {
                TempData["EditRole"] = "You have added successfully ";

                return RedirectToAction("Index", "role");
            }
            return View();
            // return RedirectToAction("Index", "role");

        }
        [Route("Admin/Role/Edit/{id}")]
        [HttpGet]
        public IActionResult EditRole(string id)
        {
           if(id==null)
                return RedirectToAction("NotFoundError", "Home");
            var model = services.GetRole(id).Result;

            if (TempData.ContainsKey("EditUserInRole"))
            {
                ViewBag.EditUserInRole = TempData["EditUserInRole"];
            }
            if(TempData.ContainsKey("RoleExist"))
            {
                ViewBag.RoleExist = TempData["RoleExist"];
            }

                if (model != null &&model.RoleName!="Admin")
            {
              
                var userInRole = services.ListUserInRole(id).Result;
              
                ViewBag.UserInRole = userInRole;
                return View("~/Views/Admin/Role/Edit.cshtml", model);
            }
              
            else
                return RedirectToAction("NotFoundError", "Home");
            //   model.Result.Users.Add("KIMKIM@GMAIL.CO,");

        }
        [Route("Admin/Role/Edit/{id}")]
        [HttpPost]
        public IActionResult EditRole(EditRoleViewModel model)
        {
            if (model.RoleName.ToLower() == "admin")
            {
                TempData["RoleExist"] = "Can not edit role name into admin";
                return RedirectToRoute(new { action = "EditRole", controller = "Role" });
            }
            var role = services.GetRole(model.Id).Result;
         
            if (role.RoleName!=model.RoleName && services.CheckRole(model.RoleName).Result==true)
            {
                TempData["RoleExist"] = "this role has exist";
                return RedirectToRoute(new { action = "EditRole", controller = "Role" });
            }
            else
            {
                var result = services.EditRole(model);
                if (result.Result == true)
                {
                    TempData["EditRole"] = "You have edidted this role successfully ";
                    return RedirectToRoute(new { action = "index", controller = "Role" });
                }

            }

            return View("~/Views/Admin/Role/Edit.cshtml", model);
        }
      
        [Route("Admin/Role/EditUserInRole/{id}")]
        [HttpPost]
        public IActionResult EditUserInRole(List<UserRoleViewModel> model, string id)
        {

            if (model==null)
                return View();
         
            bool result = services.EditUserInRole(model, id).Result;

            if (result == true)
            {
                TempData["EditUserInRole"] = "You have added or removed users in this role successfully ";
                return RedirectToRoute(new { action = "EditRole", controller = "Role", id=id });
                //  return Redirect(ControllerContext.HttpContext.Request.UrlReferrer.ToString());
            }
                
            else
                return View();
        }
      
   
        public IActionResult DeleteRole(string id)
        {
          
            var result = services.DeleteRole(id);
            if (result.Result == null)
                return RedirectToAction("NotFoundError", "Home");
            else
            {
            
                if (result.Result== "success")
                {
                    TempData["EditRole"] = "you have deleted successfully";
                
                }
                else
                {
                    TempData["Error"] = "delete fail because have user in this role";
                }
                return RedirectToRoute(new { action = "Index", controller = "Role" });
            }
           
        }
    }
}
         