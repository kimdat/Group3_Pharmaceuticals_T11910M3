using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Data;
using PharmaceuticalsCompany.Services.Product;
using PharmaceuticalsCompany.Models.Products;
using Microsoft.AspNetCore.Http;
using System.IO;
 
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PharmaceuticalsCompany.Controllers
{
    public class ProductController : Controller
    {
        private ICapsules capsules;
        public ProductController(ICapsules capsules)
        {
            this.capsules = capsules;
        }


        [Route("/Admin/ProductCapsule")]
        public IActionResult Index()
        {
            var list = capsules.GetProductCapsules();
            return View("~/Views/Admin/ProductCapsule/index.cshtml",list);
        }
        [Route("/Admin/ProductCapsule/Create")]
        public IActionResult Create()
        {
            return View("~/Views/Admin/ProductCapsule/Create.cshtml");
        }
        [Route("/Admin/ProductCapsule/Create")]
        [HttpPost]
        public IActionResult Create(ProductCapsule capsule, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file == null)
                    {
                        capsules.addProductCapsules(capsule);
                        return RedirectToAction("index");

                    }
                    if (file != null && file.Length>0)
                    {
                        string filePath = Path.Combine("wwwroot/images", file.FileName);
                        var stream = new FileStream(filePath, FileMode.Create);
                        file.CopyToAsync(stream);

                        capsule.photo = "images/" + file.FileName;

                        var add = capsules.addProductCapsules(capsule);
                        return RedirectToAction("index");
                    }
                    else
                    {
                        ViewBag.Msg = "Fail !";
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;
            }
            return View();

        }
        [Route("/Admin/ProductCapsule/Update/{id}")]
        public IActionResult Update(int id)
        {
            ProductCapsule c = capsules.GetProductCapsule(id);
            if (c == null)
            {
                return this.StatusCode(StatusCodes.Status418ImATeapot, "Error message");

            }
            else
            {
                return View("~/Views/Admin/ProductCapsule/update.cshtml",capsules.GetProductCapsule(id));
            }


        }
        [Route("/Admin/ProductCapsule/Update/{id}")]
        [HttpPost]

        public IActionResult Update(ProductCapsule capsule, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file == null)
                    {
                        capsules.updateProductCapsules(capsule);
                        return RedirectToAction("index");

                    }
                    if (file.Length > 0)
                    {
                        string filePath = Path.Combine("wwwroot/images", file.FileName);
                        var stream = new FileStream(filePath, FileMode.Create);
                        file.CopyToAsync(stream);

                        capsule.photo = "images/" + file.FileName;

                        capsules.updateProductCapsules(capsule);
                        return RedirectToAction("index");

                    }
                    else
                    {
                        ViewBag.Msg = "fail";
                    }
                }
            }
            catch (Exception e)
            {

                ViewBag.Msg = e.Message;
            }
            return View("~/Views/Admin/ProductCapsule/Update.cshtml");
        }
        [Route("/Admin/ProductCapsule/Delete/{id}")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View("~/Views/Admin/ProductCapsule/Delete.cshtml",capsules.GetProductCapsule(id)) ;
        }
        [Route("/Admin/ProductCapsule/Delete/{id}")]
        [HttpPost]
        public IActionResult delete(ProductCapsule capsule, IFormFile file)
        {
            try
            {
                capsules.RemoveProductCapsules(capsule);
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
                
            }
            return RedirectToAction();
            
        }
        /*         
             [HttpPost]
                 public IActionResult delete(int id)
                 {
                 return View(capsules.GetProductCapsule(id));

                 }
             [HttpPost]
             public IActionResult delete(ProductCapsule capsule)
             {
                 try
                 {
                     capsules.RemoveProductCapsules(capsule);
                     return RedirectToAction("index");
                 }
                 catch (Exception e)
                 {


                     ViewBag.Msg = e.Message;

                 }
                 return View();

             }
     */
        /*  public IActionResult delete(int id)
          {
              ProductCapsule cap = context.ProductCapsules.FirstOrDefault(c => c.CapId.Equals(id));
              context.ProductCapsules.Remove(cap);
              return RedirectToAction("index");
          }*/
        [Route("ProductCapsule")]


        public IActionResult show()
        {

            var list = capsules.GetProductCapsules();
            return View("~/Views/ProductCapsule/show.cshtml",list);
        }
        [Route("/Admin/ProductCapsule/Detail/{id}")]
        public IActionResult detail(int id)
        {
            ProductCapsule c = capsules.GetProductCapsule(id);
            if (c == null)
            {
                return this.StatusCode(StatusCodes.Status418ImATeapot, "Error message");

            }
            else
            {
                return View("~/Views/Admin/ProductCapsule/detail.cshtml", capsules.GetProductCapsule(id));

            }


        }
    }
    }
