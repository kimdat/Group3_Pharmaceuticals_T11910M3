using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models;
using PharmaceuticalsCompany.Services.Contact;
using PharmaceuticalsCompany.Data;
namespace PharmaceuticalsCompany.Services.Contact
{
    public class ContactServices : IContact
    {
        private ApplicationDbContext context;
        public ContactServices(ApplicationDbContext context)
        {
            this.context = context;
        }
        public List<ContactUs> GetContactUs()
        {
            return context.ContactUs.ToList();

        }

        public ContactUs GetContact(int id)
        {
            ContactUs con = context.ContactUs.SingleOrDefault(c => c.CId.Equals(id));
            return con;

        }

        public  void addContact(ContactUs contact)
        {
            context.ContactUs.Add(contact);
            context.SaveChanges();
            return ;
            
        }
    }
}
