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
        SiteContext SiteContext;
        public CitiesRepo(SiteContext SiteContext)
        {
            this.SiteContext = SiteContext;
            
        }
        public List<City> GetAll()
        {
           return SiteContext.Cities.ToList();
        }

        public City Create(City item)
        {
            throw new NotImplementedException();
        }
        public City Update(int Id, City item)
        {
            throw new NotImplementedException();
        }

        public City Delete(City item)
        {
            throw new NotImplementedException();
        }

       

        
    }
}
