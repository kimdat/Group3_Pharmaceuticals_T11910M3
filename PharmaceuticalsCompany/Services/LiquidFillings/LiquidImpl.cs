using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models.Products;
using PharmaceuticalsCompany.Services.LiquidFillings;
using PharmaceuticalsCompany.Data;
namespace PharmaceuticalsCompany.Services.LiquidFillings
{
    public class LiquidImpl : ILiquid
    {
        private ApplicationDbContext context;
        public LiquidImpl(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool addProductLiquiFilling(ProductLiquidFilling productLiquidFilling)
        {
            context.ProductLiquidFillings.Add(productLiquidFilling);
            context.SaveChanges();
            return true;
        }

        public List<ProductLiquidFilling> GetProductLiquidFilling()
        {
            return context.ProductLiquidFillings.ToList();
        }

        public ProductLiquidFilling GetProductLiquidFillings(int id)
        {
            ProductLiquidFilling liquidFilling = context.ProductLiquidFillings.SingleOrDefault(c => c.LFId.Equals(id));
            return liquidFilling;
        }

        public void removeProductLiquidFilling(ProductLiquidFilling productLiquidFilling)
        {
          
            ProductLiquidFilling liquidFilling = context.ProductLiquidFillings.Find(productLiquidFilling.LFId);
            if (liquidFilling!=null)
            {
                context.Remove(liquidFilling);
                context.SaveChanges();

            }
        }

        public void updateProductLiquiFilling(ProductLiquidFilling productLiquidFilling)
        {
           
            var pat = context.ProductLiquidFillings.SingleOrDefault(p => p.LFId.Equals(productLiquidFilling.LFId));
            if (pat!=null)
            {
                pat.LFName = productLiquidFilling.LFName;
                pat.AirPressure = productLiquidFilling.AirPressure;
                pat.Air_Volume = productLiquidFilling.Air_Volume;
                pat.FillingSpeed = productLiquidFilling.FillingSpeed;
                pat.FillingRange = productLiquidFilling.FillingRange;
                pat.AriPhoto = productLiquidFilling.AriPhoto;
                context.SaveChanges()
;            }

        }
    }
}
