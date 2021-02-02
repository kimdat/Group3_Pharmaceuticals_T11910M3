using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PharmaceuticalsCompany.Models.Career;
using PharmaceuticalsCompany.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace PharmaceuticalsCompany.Services.Career
{
    public class CareerServiceImpl : ICareerService
    {
        private readonly UserManager<ApplicationUser> _um;
        private readonly SignInManager<ApplicationUser> _sm;
        private ApplicationDbContext context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CareerServiceImpl(UserManager<ApplicationUser> um, SignInManager<ApplicationUser> sm,ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _um = um;
            _sm = sm;
            this.context = context;
            _httpContextAccessor = httpContextAccessor;

        }

        public  async Task<CareerModel> GetUser()
        {
            var userid =  _um.GetUserId(_httpContextAccessor.HttpContext.User);
            ApplicationUser user = await _um.FindByIdAsync(userid);
           
            if (user != null)
            {
                CareerModel career = new CareerModel();
                career.Id = userid;
                career.Email = user.Email;
                career.Address = user.Address;
                career.Phone = user.PhoneNumber;
                career.DateOfBirth = user.DateOfBirth;
                   career.Gender = user.Gender;
                career.Photo = user.Photo;
                career.Resume = user.Resume;
                career.FullName = user.FullName;
                return  career;
            }
            else
                return null;
                 
        }

        public async Task<CareerModel> Login(CareerModel career)
        {
          
                var result = await _sm.PasswordSignInAsync(career.Email, career.PassWord, false, false);

                if (result.Succeeded)
                {
                    return career;
                }
                else
                {
                    return null;
                }
           
            
        }

        public async Task<CareerModel> Logout()
        {
            await _sm.SignOutAsync();
            return null;
        }

      
        public async Task<CareerModel> EditResume(CareerModel career)
        {
            var user = await _um.FindByIdAsync(career.Id);

            user.Resume = career.Resume;


            var result = await _um.UpdateAsync(user);
            if (result.Succeeded)
            {


                return career;
            }
            else
            {
                return null;
            }

        }

        public async Task<CareerModel> EditProfile(CareerModel career)
        {
              var user = await _um.FindByIdAsync(career.Id);

              user.Address = career.Address;
                user.DateOfBirth = career.DateOfBirth;
               user.Gender = career.Gender;
                user.PhoneNumber = career.Phone;
                user.Photo = career.Photo;
                user.FullName = career.FullName;
            
          
            var result = await _um.UpdateAsync(user);
            if (result.Succeeded)
            {

               
                return career;
            }
            else
            {
                return null;
            }

        }

        public async Task<ApplicationUser> Register(CareerModel career, ICollection<EducationDetails> educationDetails)
        {
            var user = new ApplicationUser
            {
                UserName = career.Email,
                Email = career.Email,
                DateOfBirth = career.DateOfBirth,
                Gender = career.Gender,
                Resume = career.Resume,
                Address = career.Address,
                Photo = career.Photo,
                PhoneNumber = career.Phone,
                FullName = career.FullName
            };
            var result = await _um.CreateAsync(user, career.PassWord);
         
            foreach (var educationDetail in educationDetails)
            {
                
              
                educationDetail.User_id = user.Id;
                context.EducationDetails.Add(educationDetail);
                context.SaveChanges();
            }


            if (result.Succeeded)
            {
                
               // await _sm.SignInAsync(user, isPersistent: false);
                return  user;
            }
            else
            {
                return null;
            }
        }

      

        public async Task<IEnumerable<EducationDetails>> GetEducationDetails()
        {
            var userid = _um.GetUserId(_httpContextAccessor.HttpContext.User);
            return await context.EducationDetails.Where(e=>e.User_id==userid).ToListAsync();
        }

        public async Task<bool> EditEducationDetails(IEnumerable<EducationDetails> educationDetails)
        {
            var user_id = _um.GetUserId(_httpContextAccessor.HttpContext.User);
            var list = context.EducationDetails.Where(e => e.User_id == user_id);
            foreach (var item in  list)
            {
               context.EducationDetails.Remove(item);
            }
            
            foreach (var NewEducationDetail in educationDetails)
            {
               
                NewEducationDetail.User_id = user_id;
                context.EducationDetails.Add(NewEducationDetail);
             
              
            }
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<IdentityResult> ChangePassWord(ChangePassWordViewModel model)
        {
            var user = await _um.GetUserAsync(_httpContextAccessor.HttpContext.User);
            if (user == null)
                return null;
            var result = await _um.ChangePasswordAsync(user, model.CurrentPassWord, model.NewPassWord);
            return result;
              
          
          

          
        }

        public async Task<bool> CheckMail(string email)
        {
            var  a = await context.Users.SingleOrDefaultAsync(e => e.Email.Equals(email));
            if (a == null)
                return true;
            else
                return false;
        }

        public async Task<Dictionary<string, string>> ValidPassWord(string pass)
        {

            Dictionary<string, string> passwordErrors = new Dictionary<string, string>();

            if (pass == null)
                return passwordErrors;
            else

            {
                var validators = _um.PasswordValidators;

                foreach (var validator in validators)
                {
                    var result = await validator.ValidateAsync(_um, null, pass);

                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {

                            passwordErrors.Add(error.Code, error.Description);
                        }
                    }
                }
            }
               
            return passwordErrors;
            // Valid Password

        }

        public async Task<string> CheckIsAdminAndVerity(string email)
        {
            //var userid = _um.GetUserId(_httpContextAccessor.HttpContext.User);
            ApplicationUser user = await _um.FindByEmailAsync(email);

            if(user==null)
                return null;
            else
            {
                if (await _um.IsInRoleAsync(user, "Admin"))
                    return "admin";
                else if (user.EmailConfirmed)
                    return "user";
                else
                    return null;
            }
           
         
        }

        public async Task<string> GetToken(ApplicationUser user)
        {

            var code = await _um.GenerateEmailConfirmationTokenAsync(user);
            return code;
        }

        public  async Task<bool> VertiFyEmail(string userId, string token)
        {
            var user = await _um.FindByIdAsync(userId);
            if (user == null)
                return false;
            var result = await _um.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                await _sm.SignInAsync(user,false);
                return true;
            }
            else
            {
                return false;
            }
        }

        public  async Task<string> checkEmailUserConFirm(string id)
        {
            ApplicationUser user = await _um.FindByIdAsync(id);
            if(user==null)
            {
                return null;
            }
            if (user.EmailConfirmed)
                return "true";
            else
                return  "false";
        }

        public async Task<string> GetToKenReset(string email)
        {
            var user = await _um.FindByEmailAsync(email);
            if(user!=null && await _um.IsEmailConfirmedAsync(user))
            {
                var token=await _um.GeneratePasswordResetTokenAsync(user);
                return token;

            }
            else
            {
                return null;
            }
        }

        public async Task<string> ResetPassWord(ResetPassWordViewModels models)
        {
            var user = await _um.FindByEmailAsync(models.Email);
            if(user!=null)
            {
                var result = await _um.ResetPasswordAsync(user, models.token, models.PassWord);
                if (result.Succeeded)
                {
                    await _sm.SignInAsync(user, false);
                    return "sucess";
                }
                    
                else
                    return "failed";
            }
            else
            {
                return null;
            }

        }

        public async Task<bool> CheckValidTokenReset(string token,string email)
        {
            var user = await _um.FindByEmailAsync(email);
            if (user == null)
                return false;
            if (await _um.VerifyUserTokenAsync(user, _um.Options.Tokens.PasswordResetTokenProvider, "ResetPassword", token))
               return true;
            else
                return false;
        }
    }
}
