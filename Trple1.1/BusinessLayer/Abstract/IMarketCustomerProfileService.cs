using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMarketCustomerProfileService
    {
        List<MarketCustomerProfile> GetList();
        void MarketCustomerProfileAdd(MarketCustomerProfile MarketCustomerProfile);
        MarketCustomerProfile GetById(int id);
        void MarketCustomerProfileDelete(MarketCustomerProfile MarketCustomerProfile);
        void MarketCustomerProfileUpdate(MarketCustomerProfile MarketCustomerProfile);
    }
}
