using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICariService
    {
        List<Cari> GetList();
        void CariAdd(Cari Cari);
        Cari GetById(long id);
        void CariDelete(Cari Cari);
        void CariUpdate(Cari Cari);
    }
}
