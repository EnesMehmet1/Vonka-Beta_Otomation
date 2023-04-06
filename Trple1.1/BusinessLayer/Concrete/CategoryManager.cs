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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal cd;

        public CategoryManager(ICategoryDal cd)
        {
            this.cd = cd;
        }

        public Category GetById(long id)
        {
            return cd.Get(x => x.categoryID == id);
        }

        public List<Category> GetList()
        {
            return cd.List();
        }
        public void CategoryDelete(Category Category)
        {
            cd.Delete(Category);
        }

        public void CategorykAdd(Category Category)
        {
            cd.Insert(Category);
        }

        public void CategoryUpdate(Category Category)
        {
            cd.Update(Category);
        }


    }
}
