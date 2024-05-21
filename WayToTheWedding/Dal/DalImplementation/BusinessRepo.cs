using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class BusinessRepo : IBusinessRepo
    {
        SiteContext siteContext;
        public BusinessRepo(SiteContext siteContext)
        {
            this.siteContext = siteContext;
        }
        public List<Business> GetAll()
        {
            return siteContext.Businesses.ToList();
        }
        public Business Create(Business item)
        {
            throw new NotImplementedException();
        }

        public Business Delete(Business item)
        {
            throw new NotImplementedException();
        }

       

        public Business Update(int Id, Business item)
        {
            throw new NotImplementedException();
        }
    }
}
