using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmaceuticalsCompany.Models;
using PharmaceuticalsCompany.Models.Career;
using PharmaceuticalsCompany.Services.Career;
namespace PharmaceuticalsCompany.Controllers
{
    public class HomeController : Controller
    {
        private ICareerService service;
        public HomeController(ICareerService service)
        {
            this.service = service;
        }
        public IActionResult NotFoundError()
        {
            return View();
        }
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch(statusCode)
            {
                case 404:
                    break;
            }
            return View("NotFoundError");

        }
      
        
        [Route("Admin")]
        [Authorize(Roles ="Admin")]
        public IActionResult AdminPage()
        {
            return View("~/Views/Admin/Index.cshtml");
        }
        
        [Route("Admin/Login")]
        [HttpGet]
        public IActionResult Login()
        {

            if (User.IsInRole("Admin"))
                return RedirectToAction("AdminPage");
            else

                return View("~/Views/Admin/Login.cshtml");


        }
        [Route("Admin/Login")]
        [HttpPost]
        public async Task<IActionResult> Login(CareerModel candidate)
        {
           

            var result =service.CheckIsAdminAndVerity(candidate.Email).Result;
                if(result!="admin")

            {
                return Json(new
                {
                    success = false

                });
            }
            var model = await service.Login(candidate);

            if (model != null )
            {

              
                    return Json(new
                    {
                        success = true,
                      
                    });
               

            }
            else
            {
                return Json(new
                {
                    success = false

                });
            }




        }


        [Route("Admin/AccessDenied")]
        public IActionResult Acess()
        {
            return View("~/Views/Admin/AccessDenied.cshtml");

        }

       [Route("Home")]
        public IActionResult Index()
        {

            return View();


        }
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
