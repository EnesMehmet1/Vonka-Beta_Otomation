using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITypeSalesService
    {
        List<TypeSales> GetList();
        void typeSalesAdd(TypeSales TypeSales);
        TypeSales GetById(int id);
        void typesSalesDelete(TypeSales TypeSales);
        void typeSalesUpdate(TypeSales TypeSales);
    }
}
