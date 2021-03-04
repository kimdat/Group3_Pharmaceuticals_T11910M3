using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Data;
using PharmaceuticalsCompany.Models;

namespace PharmaceuticalsCompany.Services.Quote
{
    public interface IQuote
    {
        List<QuoteUs> GetQuoteUs();
        QuoteUs GetQuoteUs(int id);
        void addQuote(QuoteUs quote);
    }
}
