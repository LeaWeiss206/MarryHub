
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
        public HousingUnit Update(int id, HousingUnit housingUnit)
        {
            var housingUnitToUpdate = siteContext.Businesses.SingleOrDefault(b => b.Id == id);

            if (housingUnitToUpdate != null)
            {
                siteContext.Update(housingUnitToUpdate);
                siteContext.Entry(housingUnitToUpdate).CurrentValues.SetValues(housingUnit);
                siteContext.SaveChanges();
            }
            return housingUnit;
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
