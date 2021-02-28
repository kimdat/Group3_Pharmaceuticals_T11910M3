using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Data;
using PharmaceuticalsCompany.Models;
namespace PharmaceuticalsCompany.Services.Contact
{
   public interface IContact
    {
        List<ContactUs> GetContactUs();
        ContactUs GetContact(int id);
        void addContact(ContactUs contact);
        
    }
}
