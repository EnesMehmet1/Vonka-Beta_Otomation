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
    public class BrandManager : IBrandService
    {
        IBrandDal bd;

        public BrandManager(IBrandDal bd)
        {
            this.bd = bd;
        }

        public Brand GetById(long id)
        {
            return bd.Get(x => x.brandID == id);
        }

        public List<Brand> GetList()
        {
            return bd.List();
        }

        public void BrandAdd(Brand Brand)
        {
            bd.Insert(Brand);
        }

        public void BrandDelete(Brand Brand)
        {
            bd.Delete(Brand);
        }

        public void BrandUpdate(Brand Brand)
        {
            bd.Update(Brand);
        }
    }
}
