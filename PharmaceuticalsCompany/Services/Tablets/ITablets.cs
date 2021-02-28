using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmaceuticalsCompany.Models.Products;

namespace PharmaceuticalsCompany.Services.Tablets
{
   public interface ITablets
    {
        List<ProductTablet> GetProductTablest();
        ProductTablet GetProductTablets(int Id);
        bool addProductTablest(ProductTablet productTablet);
        void updateProductTablest(ProductTablet productTablet);
        void RemoveProductTablest(ProductTablet productTablet);
    }
}
