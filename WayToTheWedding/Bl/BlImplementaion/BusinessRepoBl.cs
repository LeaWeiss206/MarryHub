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
    internal class BusinessRepoBl : BlApi.IBusinessRepo
    {

        Dal.DalApi.IBusinessRepo BusinessRepo;
        IMapper map;
        public BusinessRepoBl(DalManager dalManager, IMapper map)
        {
            BusinessRepo = dalManager.BusinessRepo;
            this.map = map;
        }
        public List<Business> GetAll()
        {
            List<Business> list = new List<Business>();
            var data = BusinessRepo.GetAll();
            data.ForEach(sin => list.Add(map.Map<Bl.Bo.Business>(sin)));
            return list;
        }
        public Business Create(Business item)
        {
            throw new NotImplementedException();
        }

        public Business Delete(Business item)
        {
            throw new NotImplementedException();
        }

       

        public Business Update(int Id, Business item)
        {
            throw new NotImplementedException();
        }
    }
}
