using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models.Products;

namespace PharmaceuticalsCompany.Services.Product
{
   public interface ICapsules
    {
        List<ProductCapsule> GetProductCapsules();
        ProductCapsule GetProductCapsule(int Id);
        bool addProductCapsules(ProductCapsule productCapsule);
        void updateProductCapsules(ProductCapsule productCapsule);
        void RemoveProductCapsules(ProductCapsule productCapsule);

    }
}
