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
        public HousingUnit Create(HousingUnit item)
        {
            throw new NotImplementedException();
        }

        public HousingUnit Delete(HousingUnit item)
        {
            throw new NotImplementedException();
        }


        public HousingUnit Update(int Id, HousingUnit item)
        {
            throw new NotImplementedException();
        }
    }
}
