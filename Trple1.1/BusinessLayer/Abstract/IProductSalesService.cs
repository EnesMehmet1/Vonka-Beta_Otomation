using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductSalesService
    {
        List<productSales> GetList();
        void productSalesAdd(productSales productSales);
        productSales GetById(int id);
        void productSalesDelete(productSales productSales);
        void productSalesUpdate(productSales productSales);
    }
}
