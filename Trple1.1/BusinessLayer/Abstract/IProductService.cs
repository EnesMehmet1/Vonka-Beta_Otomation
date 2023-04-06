using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetList();
        void ProductAdd(Product Product);
        Product GetById(long id);
        void ProductDelete(Product Product);
        void ProductUpdate(Product Product);
        void ProductUpdateDemo(long barcod, int stock, string name, double price, int category, int categoryDetail, int brand, int kdv, double purchasePrice);
    }
}
