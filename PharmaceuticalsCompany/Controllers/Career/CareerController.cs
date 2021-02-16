
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PharmaceuticalsCompany.Services.Career;
using PharmaceuticalsCompany.Models.Career;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

using Spire.Doc;
using Spire.Presentation;
using Spire.Xls;
using Microsoft.Extensions.Logging;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PharmaceuticalsCompany.Controllers.Candidate
{
    public class CareerController : Controller
    {

        IHostingEnvironment _hostingEnvironment = null;
        private readonly ILogger<CareerController> logger;
        private ICareerService services;
        public CareerController(ICareerService services, IHostingEnvironment hostingEnvironment, ILogger<CareerController> logger)
        {

            _hostingEnvironment = hostingEnvironment;
            this.services = services;
            this.logger = logger;
        }
        [Route("Career")]
        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)

                return RedirectToAction("Authentication");
            else if(User.IsInRole("Admin"))
                return RedirectToAction("Index", "AdminCareer");
            else

            {
                var model = await services.GetUser();

                if(model==null)
                {
                    return RedirectToAction("Authentication");
                }
                if (TempData.ContainsKey("success"))
                {
                    ViewBag.Update = TempData["success"];
                }



                ViewBag.Education = await services.GetEducationDetails();

                // ViewBag.Msg = a;
                return View(model);
            }

        }
        public IActionResult Authentication()
        {
         if (User.Identity.IsAuthenticated )
            {
                if(!User.IsInRole("Admin"))
                    return RedirectToAction("index");
                else
                    return RedirectToAction("AdminPage","Home");
            }
      
          else

            return View();
        }

        [Route("Career/logout")]
      
        public async Task<IActionResult> logout()
        {
            await services.Logout();
            if (User.IsInRole("Admin"))
                return RedirectToAction("AdminPage", "Home");
            else
                return RedirectToAction("authentication");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(CareerModel candidate)
        {
            var check = services.CheckIsAdminAndVerity(candidate.Email).Result;
            if (check == null)
            {
                return Json(new
                {
                    success = false,
                   
                });
            }
             else
             {
                var model = await services.Login(candidate);
                if(model!=null)
                {
                    if (check == "admin")
                    {
                        return Json(new
                        {
                            success = true,
                            role = "admin"
                        });
                    }
                    else 
                    {
                        return Json(new
                        {
                            success = true,
                            role = "user"
                        });
                    }
                 
                }
                else
                {
                    return Json(new
                    {
                        success = false,

                    });
                }
               
             }
           
        }
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Register(CareerModel career, ICollection<EducationDetails> educationDetails, IFormFile file, IFormFile fileUser, [FromServices] IHostingEnvironment hostingEnvironment, string genders)
        {
            bool checkMail = services.CheckMail(career.Email).Result;

            if (checkMail != true)
            {
                ModelState.AddModelError("EmailExist", "Email  already in use");
            }
            //valid password
            var validPass = services.ValidPassWord(career.PassWord);
            if (validPass != null)
            {
                foreach (var item in validPass.Result)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }

            }

            //check model
            if (!ModelState.IsValid)
            {
                return Json(new
                {
                    success = false
                      ,
                    errors = from x in ModelState.Keys
                             where ModelState[x].Errors.Count > 0
                             select new
                             {
                                 key = x,
                                 errors = ModelState[x].Errors.
                                                               Select(y => y.ErrorMessage).
                                                               ToArray()
                             }
                });
            }
            if (genders == "male")
                career.Gender = true;
            else
                career.Gender = false;
            //upload resume and convert to pdf
            if (file != null && file.Length > 0)
            {

                string uniqueFile = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = $"{_hostingEnvironment.WebRootPath}\\files\\{ uniqueFile}";
                string fileName = file.FileName;
                if (fileName.Split(".").Last() == "pdf")
                {
                    using (FileStream fileStream = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(fileStream);
                        career.Resume =uniqueFile;
                        fileStream.Flush();
                        fileStream.Close();
                    }
                }
                else
                {
                    string extentionFile = file.FileName.Split(".").Last();
                    int indexextensionFile = file.FileName.LastIndexOf(extentionFile);
                    fileName = file.FileName.Substring(0, indexextensionFile);
                    fileName = fileName + "pdf";
                    uniqueFile = Guid.NewGuid().ToString() + "_" + fileName;
                    filePath = $"{_hostingEnvironment.WebRootPath}\\files\\{uniqueFile}";
                    using (FileStream fileStream = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(fileStream);
                        career.Resume = uniqueFile;
                        fileStream.Flush();
                        fileStream.Close();
                    }

                    if (file.FileName.Split(".").Last() == "docx" || file.FileName.Split(".").Last() == "doc" || file.FileName.Split(".").Last() == "docm" || file.FileName.Split(".").Last() == "dot" || file.FileName.Split(".").Last() == "dotx")
                    {


                        Document document = new Document();

                        document.LoadFromFile(filePath);

                        document.SaveToFile(filePath, Spire.Doc.FileFormat.PDF);



                    }

                    else if (file.FileName.Split(".").Last() == "ppt" || file.FileName.Split(".").Last() == "pptx" || file.FileName.Split(".").Last() == "pptm")
                    {
                        Presentation presentation = new Presentation();
                        presentation.LoadFromFile(filePath);
                        presentation.SaveToFile(filePath, Spire.Presentation.FileFormat.PDF);

                    }

                    else
                    {
                        Workbook workbook = new Workbook();
                        workbook.LoadFromFile(filePath);
                        Worksheet sheet = workbook.Worksheets[0];

                        sheet.SaveToPdf(filePath);

                    }

                }

            }
            //upload pho to
            if (fileUser != null && fileUser.Length > 0)
            {
                string uniqueFile = Guid.NewGuid().ToString() + "_" + fileUser.FileName;
                string filePathUser = Path.Combine("wwwroot/images", uniqueFile);
                if (!System.IO.File.Exists(filePathUser))
                {
                    var stream = new FileStream(filePathUser, FileMode.Create);
                    await fileUser.CopyToAsync(stream);

                }
                career.Photo = "images/" + uniqueFile;
            }
            var user = await services.Register(career, educationDetails);
            if (user != null)
            {
                var token = services.GetToken(user).Result;
                var link = Url.Action(nameof(VertifyEmail), "Career"
                  , new { userId = user.Id, token }, this.Request.Scheme);
                MimeMessage message = new MimeMessage();
                MailboxAddress from = new MailboxAddress("PharmaceuticaulCompany",
                "shoplaptopfpt@gmail.com");
                message.From.Add(from);
                MailboxAddress to = new MailboxAddress(user.FullName,
                user.Email);
                message.Subject = "vertify your account";

                message.To.Add(to);
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = "Hello You!please " +
                $"<a href=\"{link}\"> click here </a>" +
               "to vertify your account!Happy good day!";

                bodyBuilder.TextBody = "Hello World!";
                message.Body = bodyBuilder.ToMessageBody();
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("company13072@gmail.com", "nghiahiep");
                client.Send(message);
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
      
        public async Task<IActionResult> VertifyEmail(string userId, string token)
        {
            if (userId==null || token==null)
            {
                return RedirectToAction("NotFoundError", "Home");
            }
            if (services.checkEmailUserConFirm(userId).Result == "true")
            {
                ViewBag.Msg = "Email or token invalid or token has been expired ";
            }
            else if (services.checkEmailUserConFirm(userId).Result == null)
            {
                ViewBag.Msg = "Email or token invalid or token has been expired  ";
     
            }
            var vertify = await services.VertiFyEmail(userId, token);
            if (vertify == true)
            {
                return View();
            }

            else
            {
                ViewBag.Msg = "Email or token invalid or token has been expired";
             
            }
           
            return View();
        }
        public IActionResult PDFViewerNewTab(string fileName)
        {
            try
            {
                string path = _hostingEnvironment.WebRootPath + "\\files\\" + fileName;
                return File(System.IO.File.ReadAllBytes(path), "application/pdf");
            }
            catch (Exception ex)
            {

                return BadRequest();
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditEducation(IEnumerable<EducationDetails> educationDetails)
        {

            var a = await services.EditEducationDetails(educationDetails);
            if (a == true)
            {
                TempData["success"] = "update Education successfully";
                return RedirectToAction("index", "Career");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditResume(CareerModel career, IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {

            //  string  filePath = $"{_hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            if (file != null && file.Length > 0)
            {
                string uniqueFile = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = $"{_hostingEnvironment.WebRootPath}\\files\\{uniqueFile}";
                string fileName = uniqueFile;
                if (fileName.Split(".").Last() == "pdf")
                {
                    using (FileStream fileStream = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(fileStream);
                        career.Resume = fileName;
                        fileStream.Flush();
                        fileStream.Close();
                    }
                }
                else
                {
                    string extentionFile = file.FileName.Split(".").Last();
                    int indexextensionFile = file.FileName.LastIndexOf(extentionFile);
                    fileName = file.FileName.Substring(0, indexextensionFile);
                    fileName = fileName + "pdf";
                    uniqueFile = Guid.NewGuid().ToString() + "_" + fileName;
                    filePath = $"{_hostingEnvironment.WebRootPath}\\files\\{uniqueFile}";
                    using (FileStream fileStream = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(fileStream);
                        career.Resume =uniqueFile;
                        fileStream.Flush();
                        fileStream.Close();
                    }

                    if (file.FileName.Split(".").Last() == "docx" || file.FileName.Split(".").Last() == "doc" || file.FileName.Split(".").Last() == "docm" || file.FileName.Split(".").Last() == "dot" || file.FileName.Split(".").Last() == "dotx")
                    {


                        Document document = new Document();

                        document.LoadFromFile(filePath);

                        document.SaveToFile(filePath, Spire.Doc.FileFormat.PDF);



                    }

                    else if (file.FileName.Split(".").Last() == "ppt" || file.FileName.Split(".").Last() == "pptx" || file.FileName.Split(".").Last() == "pptm")
                    {
                        Presentation presentation = new Presentation();
                        presentation.LoadFromFile(filePath);
                        presentation.SaveToFile(filePath, Spire.Presentation.FileFormat.PDF);

                    }

                    else
                    {
                        Workbook workbook = new Workbook();
                        workbook.LoadFromFile(filePath);
                        Worksheet sheet = workbook.Worksheets[0];

                        sheet.SaveToPdf(filePath);

                    }

                }




            }


            var edit_carrer = await services.EditResume(career);
            if (edit_carrer != null)
            {
                TempData["success"] = "update Resume successfully";
                return RedirectToAction("index", "Career");
            }


            return View();
        }
        public IActionResult ChangePass()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePass(ChangePassWordViewModel model)
        {


            var changePass = await services.ChangePassWord(model);
            if (changePass.Errors.Count() == 0)
            {
                TempData["success"] = "password has been changed";
                return Json(new
                {
                    success = true
                });
            }

            else
            {
                foreach (var item in changePass.Errors)
                {
                    ModelState.AddModelError(item.Code.ToString(), item.Description);
                }
                return Json(new
                {
                    success = false,
                    errors = ModelState
                    // errors = ModelState
                    /*
                    errors = from x in ModelState.Keys
                             where ModelState[x].Errors.Count > 0
                             select new
                             {
                                 key = x,
                                 errors = ModelState[x].Errors.
                                                               Select(y => y.ErrorMessage).
                                                               ToArray()
                             }
                             */

                    // errors = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                    //  .Select(m => m.ErrorMessage).ToArray()*/
                });
            }


        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(CareerModel career, IFormFile fileUser, string Gender)
        {
            TempData["ID"] = "update  resume successfully";
            if (Gender == "male")
                career.Gender = true;
            else
                career.Gender = false;

            if (fileUser != null && fileUser.Length > 0)
            {
                string  uniqueFileUser=Guid.NewGuid().ToString()+"_"+fileUser.FileName;
                string filePath = Path.Combine("wwwroot/images", uniqueFileUser);
                if (!System.IO.File.Exists(filePath))
                {
                    var stream = new FileStream(filePath, FileMode.Create);
                    await fileUser.CopyToAsync(stream);

                }

                career.Photo = "images/" + fileUser.FileName;
            }

            var edit_carrer = await services.EditProfile(career);
            if (edit_carrer != null)
            {
                TempData["success"] = "update personal detail successfully";
                return RedirectToAction("index", "Career");
            }





            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassWord(string Email)
        {
            if (Email == null)
            {
                return RedirectToAction("NotFoundError", "Home");
            }
            else
            {
                try
                {
                   
                    var token = await services.GetToKenReset(Email);
                    if(token==null)
                    {
                        return Json(new
                        {
                            success = false
                          
                        });
                    }
                    var passWordResetLink = Url.Action("ResetPassWord", "Career", new { email = Email, token = token }, Request.Scheme);
                    ViewBag.Msg = passWordResetLink;
                    MimeMessage message = new MimeMessage();
                    MailboxAddress from = new MailboxAddress("PharmaceuticaulCompany",
                    "shoplaptopfpt@gmail.com");
                    message.From.Add(from);
                    MailboxAddress to = new MailboxAddress(Email, Email);
                    message.Subject = "Reset your account";

                    message.To.Add(to);
                    BodyBuilder bodyBuilder = new BodyBuilder();
                    bodyBuilder.HtmlBody = "Hello You!please " +
                    $"<a href=\"{passWordResetLink}\"> click here </a>" +
                   "to reset your password!Happy good day!";

                    bodyBuilder.TextBody = "Hello World!";
                    message.Body = bodyBuilder.ToMessageBody();
                    var client = new SmtpClient();
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("company13072@gmail.com", "nghiahiep");
                    client.Send(message);
                    return Json(new
                    {
                        success = true

                    });
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("", ex.Message);
                }
               
                return View();
            }
        }
        [HttpGet]
        public IActionResult ResetPassWord(string token,string email)
        {
            if (email == null ||token==null)
            {
                return RedirectToAction("NotFoundError", "Home");
            }
            
            var CheckValidToken = services.CheckValidTokenReset(token, email);
            if (!CheckValidToken.Result)
                ViewBag.InvalidToken = "email,token invalid or token has been expired";
            return View();
           // else
               // return RedirectToAction("/Career/Authentication");
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassWord(ResetPassWordViewModels model,string returnUrl)
        {
            var validPass = services.ValidPassWord(model.PassWord);
            if (validPass != null)
            {
                foreach (var item in validPass.Result)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }

            }
            if (!ModelState.IsValid)
            {
                return Json(new
                {
                    success = false
                      ,
                    errors = from x in ModelState.Keys
                             where ModelState[x].Errors.Count > 0
                             select new
                             {
                                 key = x,
                                 errors = ModelState[x].Errors.
                                                               Select(y => y.ErrorMessage).
                                                               ToArray()
                             }
                });
            }
            else
            {
                var result = await services.ResetPassWord(model);
                if (result == "sucess")
                    return Json(new
                    {
                        success = true
                   
                    });
                else
                    return Json(new
                    {
                        success = false

                    });

            }


         
         
           
           
         //   return Redirect(returnUrl);
        }
           
    }

}

 
 
 