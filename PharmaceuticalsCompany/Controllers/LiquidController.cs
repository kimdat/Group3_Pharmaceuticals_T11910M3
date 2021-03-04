using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Services.LiquidFillings;
using PharmaceuticalsCompany.Models.Products;
using Microsoft.AspNetCore.Http;
using System.IO;
namespace PharmaceuticalsCompany.Controllers
{
    public class LiquidController : Controller
    {
        private ILiquid liquid;
        public LiquidController(ILiquid liquid)
        {
            this.liquid = liquid;
        }
        [Route("Admin/LiquidFilling/")]
        public IActionResult Index()
        {
            var list = liquid.GetProductLiquidFilling();
            return View("~/Views/Admin/Liquid/index.cshtml",list);
         
           
        }
        [Route("Admin/LiquidFilling/Create")]
        public IActionResult Create()
        {
            return View("~/Views/Admin/Liquid/create.cshtml");
        }
        [Route("Admin/LiquidFilling/Create")]
        [HttpPost]
        public IActionResult Create(ProductLiquidFilling liquidFilling, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file == null)
                    {
                       liquid.addProductLiquiFilling(liquidFilling);
                        return RedirectToAction("index");

                    }
                    if (file!=null && file.Length>0)
                    {
                        string filePath = Path.Combine("wwwroot/images", file.FileName);
                        if (!Directory.Exists(filePath))
                        {
                            var stream = new FileStream(filePath, FileMode.Create);
                            file.CopyToAsync(stream);
                        }
                            

                        liquidFilling.AriPhoto = "images/" + file.FileName;

                        var add = liquid.addProductLiquiFilling(liquidFilling);
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
            return View("~/Views/Admin/Liquid/create.cshtml");


        }
        [Route("Admin/LiquidFilling/Edit/{id}")]
        public IActionResult Update(int id)
        {
            ProductLiquidFilling liquidFilling = liquid.GetProductLiquidFillings(id);
            if (liquidFilling == null)
            {
                return this.StatusCode(StatusCodes.Status418ImATeapot, "Error message");

            }
            else
            {
                return View("~/Views/Admin/Liquid/Update.cshtml", liquid.GetProductLiquidFillings(id));
               
            }


        }
        [Route("Admin/LiquidFilling/Edit/{id}")]
        [HttpPost]
        public IActionResult Update(ProductLiquidFilling liquidFilling, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file == null)
                    {
                        liquid.updateProductLiquiFilling(liquidFilling);
                        return RedirectToAction("index");

                    }
                    if (file!=null && file.Length>0)
                    {
                        string filePath = Path.Combine("wwwroot/images", file.FileName);
                        if (!Directory.Exists(filePath))
                        {
                            var stream = new FileStream(filePath, FileMode.Create);
                            file.CopyToAsync(stream);

                        }

                       

                        liquidFilling.AriPhoto = "images/" + file.FileName;
                        liquid.updateProductLiquiFilling(liquidFilling);
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
            return View("~/Views/Admin/Liquid/Update.cshtml", liquid.GetProductLiquidFillings(liquidFilling.LFId));


        }
        [Route("Admin/LiquidFilling/Delete/{id}")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View("~/Views/Admin/Liquid/Delete.cshtml",liquid.GetProductLiquidFillings(id));
        }
        [Route("Admin/LiquidFilling/Delete/{id}")]
        [HttpPost]
        public IActionResult delete(ProductLiquidFilling liquidFilling, IFormFile file)
        {
            try
            {
                liquid.removeProductLiquidFilling(liquidFilling);
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;

            }
            return RedirectToAction("index");

        }
        [Route("/LiquidFilling")]
        public IActionResult showLiquid()
        {


            var list = liquid.GetProductLiquidFilling();
            return View(list);
        }
        [Route("/LiquidFilling/Detail/{id}")]
        public IActionResult detail(int id, IFormFile file)
        {
            ProductLiquidFilling liquidFilling = liquid.GetProductLiquidFillings(id);
            if (liquidFilling == null)
            {
                return this.StatusCode(StatusCodes.Status418ImATeapot, "Error message");

            }
            else
            {
                return View(liquid.GetProductLiquidFillings(id));
            }


        }
    }
}
