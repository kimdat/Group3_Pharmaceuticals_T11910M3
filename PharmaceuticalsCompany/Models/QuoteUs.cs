using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalsCompany.Models
{
    public class QuoteUs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Comments { get; set; }

    }
}
