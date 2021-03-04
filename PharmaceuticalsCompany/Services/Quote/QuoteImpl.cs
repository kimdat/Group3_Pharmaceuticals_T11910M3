using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models;
using PharmaceuticalsCompany.Services.Contact;
using PharmaceuticalsCompany.Data;
namespace PharmaceuticalsCompany.Services.Quote
{
    public class QuoteServices : IQuote
    {
        private ApplicationDbContext context;
        public QuoteServices(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void addQuote(QuoteUs quote)
        {
            context.QuoteUs.Add(quote);
            context.SaveChanges();
            return;
        }

        public List<QuoteUs> GetQuoteUs()
        {
            return context.QuoteUs.ToList();
        }

        public QuoteUs GetQuoteUs(int id)
        {
            QuoteUs con = context.QuoteUs.SingleOrDefault(c => c.Id.Equals(id));
            return con;
        }
    }
}
