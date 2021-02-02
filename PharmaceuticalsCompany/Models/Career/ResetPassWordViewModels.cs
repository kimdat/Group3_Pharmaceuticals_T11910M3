using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalsCompany.Models.Career
{
    public class ResetPassWordViewModels
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public  string PassWord { get; set; }
        [Required]
        [Compare("PassWord",ErrorMessage ="PassWord and confirm password must match")]
        [DataType(DataType.Password)]
        public string ConfirmPassWord { get; set; }
        public string token { get; set; }
    }
}
