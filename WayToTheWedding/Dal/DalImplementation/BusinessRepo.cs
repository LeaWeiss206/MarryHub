using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections;
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
            return siteContext.Businesses.OrderByDescending(b => b.Stars).ToList();
        }
        public List<Business> GetByCityAndCategory(int city, int category)
        {
            return siteContext.Businesses
                .Where(b => b.CityId == city && b.Category == category)
                .OrderByDescending(b => b.Stars)
                .ToList();
        }
        public Business Create(Business item)
        {
            siteContext.Businesses.Add(item);
            siteContext.SaveChanges();
            return item;
        }
        public Business Update(int id, Business business)
        {
             var businessToUpdate = siteContext.Businesses.SingleOrDefault(b => b.Id == id);

             if (businessToUpdate != null)
             {
                siteContext.Update(businessToUpdate);
                siteContext.Entry(businessToUpdate).CurrentValues.SetValues(business);
                siteContext.SaveChanges();
             }
        return businessToUpdate;
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
