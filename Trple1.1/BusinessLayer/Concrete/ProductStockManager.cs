using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductStockManager : IProductStockService
    {
        IProductStockDal psd;

        public ProductStockManager(IProductStockDal psd)
        {
            this.psd = psd;
        }

        public ProductStock GetById(int id)
        {
            return psd.Get(x => x.StockId == id);
        }

        public List<ProductStock> GetList()
        {
            return psd.List();
        }

        public void ProductStockAdd(ProductStock ProductStock)
        {
            psd.Insert(ProductStock);
        }

        public void ProductStockDelete(ProductStock ProductStock)
        {
            psd.Delete(ProductStock);
        }

        public void ProductStockUpdate(ProductStock ProductStock)
        {
            psd.Update(ProductStock);
        }
    }
}
