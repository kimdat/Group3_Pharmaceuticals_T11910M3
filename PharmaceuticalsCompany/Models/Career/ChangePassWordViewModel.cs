using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalsCompany.Models.Career
{
    public class ChangePassWordViewModel
    {
        [Required]
        public string CurrentPassWord { get; set; }
        [Required]
        [Compare("ConFirmNewPassWord")]
        public string NewPassWord { get; set; }
        [Required]
        [Compare("NewPassWord")]
        public string ConFirmNewPassWord { get; set; }
    }
}
