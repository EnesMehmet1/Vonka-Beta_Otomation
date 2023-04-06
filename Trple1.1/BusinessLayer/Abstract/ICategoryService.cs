using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategorykAdd(Category Category);
        Category GetById(long id);
        void CategoryDelete(Category Category);
        void CategoryUpdate(Category Category);
    }
}
