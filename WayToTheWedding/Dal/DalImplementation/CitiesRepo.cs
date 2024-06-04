using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class CitiesRepo : ICitiesRepo
    {
        SiteContext siteContext;
        public CitiesRepo(SiteContext siteContext)
        {
            this.siteContext = siteContext;
            
        }
        public List<City> GetAll()
        {
           return siteContext.Cities.ToList();
        }

        public City Create(City item)
        {
            siteContext.Cities.Add(item);
            siteContext.SaveChanges();
            return item;
        }
        public City Update(int Id, City item)
        {
            throw new NotImplementedException();
        }

        public City Delete(int id)
        {
            throw new NotImplementedException();
        }

       

        
    }
}
