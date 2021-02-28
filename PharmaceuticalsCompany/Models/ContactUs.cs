using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace PharmaceuticalsCompany.Models
{
    public class ContactUs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CId { get; set; }
        public string CName { get; set; }
        [Required]
        public int CPhone { get; set; }
        [Required]
        public string FeedBack { get; set; }
    }
}
