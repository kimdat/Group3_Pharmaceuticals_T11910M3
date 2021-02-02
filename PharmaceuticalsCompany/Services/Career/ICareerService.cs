using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PharmaceuticalsCompany.Models.Career;
namespace PharmaceuticalsCompany.Services.Career
{
    public interface ICareerService
    {
         Task<CareerModel> Login(CareerModel career);
        Task<ApplicationUser> Register(CareerModel career, ICollection<EducationDetails> educationDetails);
        Task<CareerModel> Logout();
        Task<CareerModel> GetUser();
        Task<IdentityResult> ChangePassWord(ChangePassWordViewModel model);
        Task<CareerModel> EditProfile(CareerModel career);
        Task<bool> CheckMail(string email);
        Task<CareerModel> EditResume(CareerModel career);
        Task<bool> EditEducationDetails(IEnumerable<EducationDetails> educationDetails);
        Task<IEnumerable<EducationDetails>> GetEducationDetails();
        Task<Dictionary<string, string>> ValidPassWord(string pass);
        Task<string> CheckIsAdminAndVerity(string email);
        Task<string> GetToken(ApplicationUser user);
        Task<bool> VertiFyEmail(string userId, string token);
        Task<string> checkEmailUserConFirm(string id);
        Task<string> GetToKenReset(string email);
        Task<string> ResetPassWord(ResetPassWordViewModels models);
        Task<bool> CheckValidTokenReset(string token,string email);
        //admin
       
    }
}
