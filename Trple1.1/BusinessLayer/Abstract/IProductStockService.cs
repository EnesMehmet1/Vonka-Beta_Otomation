using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductStockService
    {
        List<ProductStock> GetList();
        void ProductStockAdd(ProductStock ProductStock);
        ProductStock GetById(int id);
        void ProductStockDelete(ProductStock ProductStock);
        void ProductStockUpdate(ProductStock ProductStock);
    }
}
