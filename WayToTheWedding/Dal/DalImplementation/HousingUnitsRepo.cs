using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class HousingUnitsRepo : IHousingUnitsRepo
    {
        SiteContext siteContext;
        public HousingUnitsRepo(SiteContext siteContext)
        {
            this.siteContext = siteContext;
        }
        public List<HousingUnit> GetAll()
        {
           return siteContext.HousingUnits.ToList();
        }
        public HousingUnit Create(HousingUnit item)
        {
            siteContext.HousingUnits.Add(item);
            siteContext.SaveChanges();
            return item;
        }
        public HousingUnit Update(int Id, HousingUnit item)
        {
            HousingUnit housingUnit = siteContext.HousingUnits.FirstOrDefault(b=>b.Id == Id);

            siteContext.HousingUnits.ToList()[Id] = item;
            siteContext.SaveChanges();
            return item;
        }

        public HousingUnit Delete(int id)
        {
            HousingUnit housingUnit = siteContext.HousingUnits.FirstOrDefault(b => b.Id == id);
            siteContext.HousingUnits.Remove(housingUnit);
            siteContext.SaveChanges();
            return housingUnit;
        }


       
    }
}
