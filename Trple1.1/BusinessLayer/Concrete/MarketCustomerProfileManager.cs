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
    public class MarketCustomerProfileManager : IMarketCustomerProfileService
    {
        IMarketCustomerProfileDal McpDal;

        public MarketCustomerProfileManager(IMarketCustomerProfileDal mcpDal)
        {
            McpDal = mcpDal;
        }

        public MarketCustomerProfile GetById(int id)
        {
            return McpDal.Get(x => x.marketCustomerProfileID == id);
        }

        public List<MarketCustomerProfile> GetList()
        {
            return McpDal.List();
        }

        public void MarketCustomerProfileAdd(MarketCustomerProfile MarketCustomerProfile)
        {
            McpDal.Insert(MarketCustomerProfile);
        }

        public void MarketCustomerProfileDelete(MarketCustomerProfile MarketCustomerProfile)
        {
            McpDal.Delete(MarketCustomerProfile);
        }

        public void MarketCustomerProfileUpdate(MarketCustomerProfile MarketCustomerProfile)
        {
            McpDal.Update(MarketCustomerProfile);
        }
    }
}
