using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Services.Contact;
using PharmaceuticalsCompany.Models;

namespace PharmaceuticalsCompany.Controllers
{
    public class ContactController : Controller
    {
        private IContact service;
        public ContactController(IContact service)
        {
            this.service = service;
        }
        [Route("Contact")]
        public IActionResult create()
        {
            return View();
        }
        [Route("Contact")]
        [HttpPost]
        public IActionResult create(ContactUs contact)
        {
          
            try
            {
                if (ModelState.IsValid)
                {
                    service.addContact(contact);
                    return RedirectToAction("create");
                }
                else
                {
                    ViewBag.Msg = "Fail";
                }

            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;


            }
            return View();

        }
        [Route("Admin/Contact")]
        public IActionResult ShowConact()
        {
            var list = service.GetContactUs();
            return View("~/Views/Admin/Contact/Index.cshtml", list);
           
        }

    }
}
