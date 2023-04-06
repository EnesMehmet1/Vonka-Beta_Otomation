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
    public class CategoryDetailManager : ICategoryDetailService
    {
        ICategoryDetailDal cdd;

        public CategoryDetailManager(ICategoryDetailDal cdd)
        {
            this.cdd = cdd;
        }

        public CategoryDetail GetById(int id)
        {
            return cdd.Get(x => x.CategoryDetailID == id);
        }

        public List<CategoryDetail> GetList()
        {
            return cdd.List();
        }
        public void CategoryDetailDelete(CategoryDetail CategoryDetail)
        {
            cdd.Delete(CategoryDetail);
        }

        public void CategoryDetailkAdd(CategoryDetail CategoryDetail)
        {
            cdd.Insert(CategoryDetail);
        }

        public void CategoryDetailUpdate(CategoryDetail CategoryDetail)
        {
            cdd.Update(CategoryDetail);
        }
    }
}
