using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Services.Quote;
using PharmaceuticalsCompany.Models;

namespace PharmaceuticalsCompany.Controllers
{
    public class QuoteController : Controller
    {
        private IQuote service;
        public QuoteController(IQuote service)
        {
            this.service = service;
        }
        [Route("Quote")]
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [Route("Quote")]
        [HttpPost]
        public IActionResult create(QuoteUs quote)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.addQuote(quote);
                    return RedirectToAction("index");
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
        [Route("ShowQuote")]
        public IActionResult ShowQuote()
        {
            var list = service.GetQuoteUs();
            return View(list);
        }
    }
}
