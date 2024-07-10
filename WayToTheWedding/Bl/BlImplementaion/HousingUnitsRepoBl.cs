using AutoMapper;
using Bl.BlApi;
using Bl.Bo;
using Dal;
using Dal.DalApi;
using Dal.DalImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplementaion
{
    public class HousingUnitsRepoBl : BlApi.IHousingUnitsRepo
    {
        Dal.DalApi.IHousingUnitsRepo HousingUnitRepo;
        IMapper map;
        public HousingUnitsRepoBl(DalManager dalManager, IMapper map)
        {
            HousingUnitRepo = dalManager.HousingUnitRepo;
            this.map = map;
        }

        public List<HousingUnit> GetAll()
        {
            List<HousingUnit> list = new();
            var data = HousingUnitRepo.GetAll();
            data.ForEach(sin => list.Add(map.Map<HousingUnit>(sin)));
            return list;
        }
        public List<HousingUnit> GetByCity(int cityId)
        {
            List<HousingUnit> list = new();
            var data = HousingUnitRepo.GetByCity(cityId);
            data.ForEach(sin => list.Add(map.Map<HousingUnit>(sin)));
            return list;
        }

        public HousingUnit CreateUnit(HousingUnit unit, string name)
        {
            Dal.Models.HousingUnit housingUnit = map.Map<Dal.Models.HousingUnit>(unit);
            housingUnit.Name = name;
            return map.Map <HousingUnit> (HousingUnitRepo.Create(housingUnit));
            
        }
        public HousingUnit Update(int Id, HousingUnit item)
        {
            Dal.Models.HousingUnit housingUnit = map.Map<Dal.Models.HousingUnit>(item);
            housingUnit.Name = HousingUnitRepo.GetAll().FirstOrDefault(h => h.Id == Id).Name;
            return map.Map<HousingUnit>(HousingUnitRepo.Update(Id, housingUnit));

        }
        public HousingUnit Delete(int id)
        {

            return map.Map<HousingUnit>(HousingUnitRepo.Delete(id));
        }

        public HousingUnit Create(HousingUnit item)
        {
            throw new NotImplementedException();
        }

       


        

       
    }
}
