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
        public CitiesRepoBl(DalManager dalManager)
        {
            CitiesRepo = dalManager.CitiesRepo;
        }

        public List<City> GetAll()
        {
            List<City> list = new List<City>();
            foreach (var c in CitiesRepo.GetAll())
            {
                City city = new();
                city.Id = c.Id;
                city.Name = c.Name;
                list.Add(city); 
            }
            return list;
        }

        public Bo.City Create(Bo.City item)
        {
            throw new NotImplementedException();
        }

        public Bo.City Delete(Bo.City item)
        {
            throw new NotImplementedException();
        }

        

        public Bo.City Update(int Id, Bo.City item)
        {
            throw new NotImplementedException();
        }
    }
}
