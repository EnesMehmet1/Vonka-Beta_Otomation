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
    public class TypeSalesManager : ITypeSalesService
    {
        ITypeSalesDal ysd;

        public TypeSalesManager(ITypeSalesDal ysd)
        {
            this.ysd = ysd;
        }

        public TypeSales GetById(int id)
        {
           return ysd.Get(x=>x.typeSalesId==id);
        }

        public List<TypeSales> GetList()
        {
            return ysd.List();
        }

        public void typeSalesAdd(TypeSales TypeSales)
        {
            ysd.Insert(TypeSales);
        }

        public void typeSalesUpdate(TypeSales TypeSales)
        {
            ysd.Update(TypeSales);
        }

        public void typesSalesDelete(TypeSales TypeSales)
        {
            ysd.Delete(TypeSales);
        }
    }
}
