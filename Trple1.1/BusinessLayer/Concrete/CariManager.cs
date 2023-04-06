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
    public class CariManager : ICariService
    {
        ICariDal _caridal;

        public CariManager(ICariDal caridal)
        {
            _caridal = caridal;
        }

        public CariManager(ICariDal caridal, string name,
            string managerPerson, long phone1, long phone2,
            string tur, string adress, string province,
            string district, int taxCircle, int vkn,
            string email, int cariLimit, bool cariState)
        {
            Cari cari = new Cari();
            cari.title = name; cari.managerPerson = managerPerson;
            cari.phoneNumber = phone1; cari.phoneNumber2 = phone2;
            cari.accountype = tur; cari.adress = adress;
            cari.province = province; ; cari.district = district;
            cari.taxcircle = taxCircle; cari.VKN = vkn;
            cari.email = email; cari.carilimit = cariLimit;
            cari.cariState = cariState; cari.date = DateTime.Now;
            cari.balance = cariLimit;
            _caridal = caridal;
            _caridal.Insert(cari);
        }

        public CariManager(ICariDal caridal, string name,
            string managerPerson, long phone1, long phone2,
            string tur, string adress, string province,
            string district, int taxCircle, int vkn,
            string email, int cariLimit, bool cariState, Cari cari)
        {
            cari.title = name; cari.managerPerson = managerPerson;
            cari.phoneNumber = phone1; cari.phoneNumber2 = phone2;
            cari.accountype = tur; cari.adress = adress;
            cari.province = province; ; cari.district = district;
            cari.taxcircle = taxCircle; cari.VKN = vkn;
            cari.email = email; cari.carilimit = cariLimit;
            cari.cariState = cariState; cari.date = DateTime.Now;
            cari.balance = cariLimit;
            _caridal = caridal;
            _caridal.Update(cari);
        }


        public void CariAdd(Cari Cari)
        {
            _caridal.Insert(Cari);
        }

        public void CariDelete(Cari Cari)
        {
            _caridal.Delete(Cari);
        }

        public void CariUpdate(Cari Cari)
        {
            _caridal.Update(Cari);
        }

        public Cari GetById(long id)
        {
            return _caridal.Get(x => x.cariId == id);
        }

        public List<Cari> GetList()
        {
            return _caridal.List();
        }
    }
}
