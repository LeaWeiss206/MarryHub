using AutoMapper;
using Bl.Bo;
using Dal;
using Dal.DalApi;
using Dal.DalImplementation;
//using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplementaion
{
    public class CitiesRepoBl : Bl.BlApi.ICitiesRepo
    {
        ICitiesRepo CitiesRepo;
        IMapper map;
        public CitiesRepoBl(DalManager dalManager, IMapper map)
        {
            CitiesRepo = dalManager.CitiesRepo;
            this.map = map;
        }

        public List<City> GetAll()
        {
            List<City> list = new List<City>();
            var data = CitiesRepo.GetAll();
            data.ForEach(sin => list.Add(map.Map<Bl.Bo.City>(sin)));
            return list;
        }

        public Bo.City Create(Bo.City item)
        {
            throw new NotImplementedException();
        }

        public Bo.City Delete(int id)
        {
            throw new NotImplementedException();
        }

        

        public Bo.City Update(int Id, Bo.City item)
        {
            throw new NotImplementedException();
        }
    }
}
