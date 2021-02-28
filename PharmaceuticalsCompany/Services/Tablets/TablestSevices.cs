using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models.Products;
using PharmaceuticalsCompany.Services.Tablets;
using PharmaceuticalsCompany.Data;
using PharmaceuticalsCompany.Models;
namespace PharmaceuticalsCompany.Services.Tablets
{
    public class TablestSevices : ITablets
    {
        private ApplicationDbContext context;
        public TablestSevices(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool addProductTablest(ProductTablet productTablet)
        {
            context.ProductTablets.Add(productTablet);
            context.SaveChanges();
            return true;
        }

        public List<ProductTablet> GetProductTablest()
        {
            return context.ProductTablets.ToList();
        }

        public ProductTablet GetProductTablets(int Id)
        {
            ProductTablet cap = context.ProductTablets.SingleOrDefault(c => c.TabId.Equals(Id));
            return cap;
        }

        public void RemoveProductTablest(ProductTablet productTablet)
        {
            /*ProductCapsule capsule = context.ProductCapsules.Find(productCapsule.CapId);
            if (capsule != null)
            {
                context.Remove(capsule);
                context.SaveChanges();

            }*/
            ProductTablet tablet = context.ProductTablets.Find(productTablet.TabId);
            if (tablet!=null)
            {
                context.Remove(tablet);
                context.SaveChanges();

            }

        }

        public void updateProductTablest(ProductTablet productTablet)
        {
            /* var pat = context.ProductCapsules.SingleOrDefault(p => p.CapId.Equals(productCapsule.CapId));
             if (pat != null)
             {
                 pat.CapName = productCapsule.CapName;
                 pat.Ouput = productCapsule.Ouput;
                 pat.CapSize = productCapsule.CapSize;
                 pat.Machine_Dimension = productCapsule.Machine_Dimension;
                 pat.Shipping = productCapsule.Shipping;
                 pat.photo = productCapsule.photo;
                 context.SaveChanges();


             }*/
            var pat = context.ProductTablets.SingleOrDefault(p => p.TabId.Equals(productTablet.TabId));
            if (pat!=null)
            {
                pat.TabName = productTablet.TabName;
                pat.Model_Number = productTablet.Model_Number;
                pat.Dies = productTablet.Dies;
                pat.MaxPressure = productTablet.MaxPressure;
                pat.MaxDiameter = productTablet.MaxDiameter;
                pat.MaxDept = productTablet.MaxDept;
                pat.ProductCapacity = productTablet.ProductCapacity;
                pat.MachineSize = productTablet.MachineSize;
                pat.NetWeight = productTablet.NetWeight;
                pat.TabPhoto = productTablet.TabPhoto;
                context.SaveChanges();

            }

        }
    }
}
