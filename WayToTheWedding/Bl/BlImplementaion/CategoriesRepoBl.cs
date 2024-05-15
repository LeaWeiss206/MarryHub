using AutoMapper;
using Bl.Bo;
using Dal;
using Dal.DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplementaion
{
    public class CategoriesRepoBl : Bl.BlApi.ICategoriesRepo
    {
        ICategoriesRepo CategoriesRepo;
        IMapper map;
        public CategoriesRepoBl(DalManager dalManager, IMapper map)
        {
            CategoriesRepo = dalManager.CategoriesRepo;
            this.map = map;

            //  var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapper.AutoMapperProfile>());
             //map = config.CreateMapper();
             // map.ConfigurationProvider(map.ConfigurationProvider);
        }
        public List<Category> GetAll()
        {
            List<Category> list = new List<Category>();
            var data = CategoriesRepo.GetAll();
            data.ForEach(sin => list.Add(map.Map<Bl.Bo.Category>(sin)));
            //foreach(var c in CategoriesRepo.GetAll())
            //{
            //    Category c2 = new Category();
            //    c2.Name = c.Name;
            //    c2.Id = c.Id;
            //    list.Add(c2);
            //}
            return list;
        }

        public Category Create(Category item)
        {
            throw new NotImplementedException();
        }

        public Category Delete(Category item)
        {
            throw new NotImplementedException();
        }



        public Category Update(int Id, Category item)
        {
            throw new NotImplementedException();
        }
    }
}
