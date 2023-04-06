using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryDetailService
    {
        List<CategoryDetail> GetList();
        void CategoryDetailkAdd(CategoryDetail CategoryDetail);
        CategoryDetail GetById(int id);
        void CategoryDetailDelete(CategoryDetail CategoryDetail);
        void CategoryDetailUpdate(CategoryDetail CategoryDetail);
    }
}
