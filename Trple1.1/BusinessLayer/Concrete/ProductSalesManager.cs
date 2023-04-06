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
    public class ProductSalesManager : IProductSalesService
    {
        IProductSalesDal psd;

        public ProductSalesManager(IProductSalesDal psd)
        {
            this.psd = psd;
        }

        public productSales GetById(int id)
        {
            return psd.Get(x => x.salesID == id);
        }

        public List<productSales> GetList()
        {
            return psd.List();
        }

        public void productSalesAdd(productSales productSales)
        {
            psd.Insert(productSales);
        }

        public void productSalesDelete(productSales productSales)
        {
            psd.Delete(productSales);
        }

        public void productSalesUpdate(productSales productSales)
        {
            psd.Update(productSales);
        }
    }
}
