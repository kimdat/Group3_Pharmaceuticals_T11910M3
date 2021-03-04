using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models.Products;
namespace PharmaceuticalsCompany.Services.LiquidFillings
{
  public  interface ILiquid
    {
        List<ProductLiquidFilling> GetProductLiquidFilling();
        ProductLiquidFilling GetProductLiquidFillings(int id);
        bool addProductLiquiFilling(ProductLiquidFilling productLiquidFilling);
        void updateProductLiquiFilling(ProductLiquidFilling productLiquidFilling);
        void removeProductLiquidFilling(ProductLiquidFilling productLiquidFilling);
    }
}
