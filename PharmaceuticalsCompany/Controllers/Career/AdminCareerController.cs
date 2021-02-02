using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PharmaceuticalsCompany.Services.ManageCareer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using PharmaceuticalsCompany.Models.Career;
using Microsoft.AspNetCore.Authorization;

namespace PharmaceuticalsCompany.Controllers.Career
{
     [Authorize(Roles = "Admin")]
    public class AdminCareerController : Controller
    {
        IHostingEnvironment _hostingEnvironment = null;
        private  IManageCareer  services;
        public AdminCareerController(IManageCareer services, IHostingEnvironment hostingEnvironment)
        {

            _hostingEnvironment = hostingEnvironment;
            this.services = services;
        }
        [Route("Admin/Career")]
        public IActionResult Index()
        {
          
            var users = services.GetAllUser();
            return View("~/Views/Admin/Career/Index.cshtml",users);
        }
     
        [HttpPost]
      
        public IActionResult SendMail(SendMail mail)
        {
            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("PharmaceuticaulCompany",
"shoplaptopfpt@gmail.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress(mail.ReceiveName,
           mail.To);
            message.Subject = mail.Subject;

            message.To.Add(to);
            message.Body = new TextPart("plain")
            {
                Text = mail.Message
            };
            var client = new SmtpClient();
            
            client.Connect("smtp.gmail.com", 465, true);

            client.Authenticate("shoplaptopfpt@gmail.com", "AB123123");
            client.Send(message);
            return Json(new
            {
                success = true
                   
            });
        }
        [Route("Admin/Career/Profile/{id}")]
        public IActionResult Profile(string id)
        {
           
                var users = services.GetUser(id);
                if (users == null)
                    return RedirectToAction("NotFoundError", "Home");
                ViewBag.Education = services.getEducation(id);
                return View("~/Views/Admin/Career/Profile.cshtml", users);
          
        }
        [Route("Admin/Career/PDFViewerNewTab")]
        public IActionResult PDFViewerNewTab(string fileName)
        {
            try
            {
                string path = _hostingEnvironment.WebRootPath + "\\files\\" + fileName;
                return File(System.IO.File.ReadAllBytes(path), "application/pdf");
            }
            catch (Exception)
            {
                 
                return BadRequest();
            
            }
            
        }
      
    }

}
