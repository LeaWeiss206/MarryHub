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
            siteContext.Businesses.Add(item);
            siteContext.SaveChanges();
            return item;
        }
        public Business Update(int Id, Business business)
        {
            int  businessToUpdateId = siteContext.Businesses.ToList().FindIndex(b => b.Id == Id);
           // siteContext.Businesses.[businessToUpdateId] = business;
            //siteContext.Businesses.Update(business);
            siteContext.SaveChanges();
           return  siteContext.Businesses.ToList()[businessToUpdateId]; 
        }

        public Business Delete(int id)
        {
            Business business = siteContext.Businesses.FirstOrDefault(b=>b.Id == id);
            siteContext.Businesses.Remove(business);
            siteContext.SaveChanges();
            return business;
        }

       

      
    }
}
