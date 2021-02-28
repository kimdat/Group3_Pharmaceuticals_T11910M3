using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models.Products;
using PharmaceuticalsCompany.Services.Product;
using PharmaceuticalsCompany.Data;

namespace PharmaceuticalsCompany.Services.Product
{

    public class CapsulesServices : ICapsules
    {
        private ApplicationDbContext context;
        public CapsulesServices(ApplicationDbContext context)
        {
            this.context = context;
        }
        public  bool addProductCapsules(ProductCapsule productCapsule)
        {
            context.ProductCapsules.Add(productCapsule);
            context.SaveChanges();
            return true;
        }

        public ProductCapsule GetProductCapsule(int Id)
        {
            ProductCapsule cap = context.ProductCapsules.SingleOrDefault(c => c.CapId.Equals(Id));
            return cap;
        }

        public List<ProductCapsule> GetProductCapsules()
        {
            return context.ProductCapsules.ToList();
        }

        public void RemoveProductCapsules(ProductCapsule productCapsule)
        {
            ProductCapsule capsule = context.ProductCapsules.Find(productCapsule.CapId);
            if (capsule!=null)
            {
                context.Remove(capsule);
                context.SaveChanges();

            }

        }

        public void updateProductCapsules(ProductCapsule productCapsule)
        {
            var pat = context.ProductCapsules.SingleOrDefault(p => p.CapId.Equals(productCapsule.CapId));
            if (pat != null)
            {
                pat.CapName = productCapsule.CapName;
                pat.Ouput = productCapsule.Ouput;
                pat.CapSize = productCapsule.CapSize;
                pat.Machine_Dimension = productCapsule.Machine_Dimension;
                pat.Shipping = productCapsule.Shipping;
                pat.photo = productCapsule.photo;
                context.SaveChanges();
                

            }
          
        }
    }
}
