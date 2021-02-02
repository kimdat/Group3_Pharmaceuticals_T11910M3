using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmaceuticalsCompany.Data;

namespace PharmaceuticalsCompany.Controllers
{
    [Authorize(Roles = "Ad123")]
    public class ProductCapsulesController : Controller
    {
        private ApplicationDbContext context;
        public ProductCapsulesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
           
            return View(context.ProductCapsules.ToList());
        }
    }
}