using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalsCompany.Models.Career
{ 
    public class CareerModel
    {
        public string Id { get; set; }
        [Required]
     
        public string Email { get; set; }
        [Required]
        public string PassWord { get; set; }
        [Required]
        [Compare("PassWord")]
        public string ConfirmPassWord { get; set; }
        [Required]
        public string Address { get; set; }
        public bool Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
      
        public string Resume { get; set; }
        
        public string Photo { get; set; }
        [Required]
        public string  Phone { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "name must be from 6 to 50 character")]
        public string FullName { get; set; }

        public ICollection<EducationDetails> educationDetails { get; set; }
    }
}
