using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Data;
using PharmaceuticalsCompany.Services.Tablets;
using PharmaceuticalsCompany.Models.Products;
using Microsoft.AspNetCore.Http;
using System.IO;
namespace PharmaceuticalsCompany.Controllers
{
    public class TablestController : Controller
    {
        private ITablets tablets;
        public TablestController(ITablets tablets)
        {
            this.tablets = tablets;
        }
        [Route("Admin/ProductTablet")]
        public IActionResult Index()
        {
            var list = tablets.GetProductTablest();
            return View("~/Views/Admin/ProductTablet/index.cshtml", list);
        }
        [Route("/Admin/ProductTablet/Create")]
        public IActionResult Create()
        {
            return View("~/Views/Admin/ProductTablet/Create.cshtml");
        }
        [Route("/Admin/ProductTablet/Create")]
        [HttpPost]
        public IActionResult Create(ProductTablet tablet, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file == null)
                    {
                        tablets.addProductTablest(tablet);
                        return RedirectToAction("index");

                    }
                     if (file!= null && file.Length>0)
                    {
                        string filePath = Path.Combine("wwwroot/images", file.FileName);
                        if (!Directory.Exists(filePath))
                        {
                            var stream = new FileStream(filePath, FileMode.Create);
                            file.CopyToAsync(stream);

                        }

                        tablet.TabPhoto = "images/" + file.FileName;

                        var add = tablets.addProductTablest(tablet);
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
            return View("~/Views/Admin/ProductTablet/Create.cshtml");

        }
        [Route("/Admin/ProductTablet/Update/{id}")]
        public IActionResult Update(int id)
        {
            ProductTablet tablest= tablets.GetProductTablets(id);
            if (tablest == null)
            {
                return this.StatusCode(StatusCodes.Status418ImATeapot, "Error message");

            }
            else
            {
                return View("~/Views/Admin/ProductTablet/Update.cshtml",tablets.GetProductTablets(id));
            }


        }
        [Route("/Admin/ProductTablet/Update/{id}")]
        [HttpPost]
        public IActionResult Update(ProductTablet tablet, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file == null)
                    {
                        tablets.updateProductTablest(tablet);
                        return RedirectToAction("index");

                    }
                    if (file != null && file.Length>0)
                    {
                        string filePath = Path.Combine("wwwroot/images", file.FileName);
                        if (!Directory.Exists(filePath))
                        {
                            var stream = new FileStream(filePath, FileMode.Create);
                            file.CopyToAsync(stream);

                        }


                        tablet.TabPhoto = "images/" + file.FileName;

                        tablets.updateProductTablest(tablet);
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
            return View("~/Views/Admin/ProductTablet/Update.cshtml", tablets.GetProductTablets(tablet.TabId));


        }
        [Route("/Admin/ProductTablet/Delete/{id}")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View("~/Views/Admin/ProductTablet/Delete.cshtml", tablets.GetProductTablets(id));
        }
        [Route("/Admin/ProductTablet/Delete/{id}")]
        [HttpPost]
        public IActionResult delete(ProductTablet tablet , IFormFile file)
        {
            try
            {
                tablets.RemoveProductTablest(tablet);
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;

            }
            return RedirectToAction();

        }
        [Route("/ProductTablet")]
        public IActionResult showTablest()
        {


            var list = tablets.GetProductTablest();
            return View("~/Views/ProductTablet/showTablest.cshtml",  list);
        }
        [Route("/ProductTablet/Detail/{id}")]
        public IActionResult detail(int id, IFormFile file)
        {
            ProductTablet c = tablets.GetProductTablets(id);
            if (c == null)
            {
                return this.StatusCode(StatusCodes.Status418ImATeapot, "Error message");

            }
            else
            {
                return View("~/Views/Admin/ProductTablet/detail.cshtml",tablets.GetProductTablets(id));
            }


        }

    }
}
