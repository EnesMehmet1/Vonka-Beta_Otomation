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
    public class ProductManager : IProductService
    {
        IProductDal ps;

        public ProductManager(IProductDal ps)
        {
            this.ps = ps;
        }
        public Product GetById(long id)
        {
            return ps.Get(x=>x.Barcod==id);
        }
        public List<Product> filterList(long s)
        {
            return ps.List(x=>x.Barcod == s);
        }
        public List<Product> GetList()
        {
            return ps.List();
        }

        public void ProductAdd(Product Product)
        {
            ps.Insert(Product);
        }

        public void ProductDelete(Product Product)
        {
            ps.Delete(Product);
        }
        public void ProductUpdate(Product Product)
        {
            ps.Update(Product);
        }
        public void ProductUpdateDemo(long barcod,int stock,string name,double price,int category,int categoryDetail,int brand,int kdv,double purchasePrice)
        {//bu kısım mımarıde uyarlanabılır
            var Product=GetById(barcod);
            Product.stockNumber = stock;
            Product.productName = name;
            Product.productPrice = price;
            Product.categoryID = category;
            Product.CategoryDetailID = categoryDetail;
            Product.brandID = brand;
            Product.KDV = kdv;
            Product.productpurchasePrice = purchasePrice;  //burası double olacak
            ps.Update(Product);
        }
    }
}
