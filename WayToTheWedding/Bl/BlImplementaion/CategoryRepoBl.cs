using Bl.BlApi;
using Bl.Bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlImplementaion
{
    public class CategoryRepo : Bl.BlApi.ICategoriesRepo
    {
        ICategoriesRepo iCategoriesRepo;
        public CategoryRepo(ICategoriesRepo iCategoriesRepo)
        {
            this.iCategoriesRepo = iCategoriesRepo;
        }
        public List<Category> GetAll()
        {
            List<Category> list = new List<Category>();

            foreach(var c in iCategoriesRepo.GetAll())
            {
                Category c2 = new Category();
                c2.Name = c.Name;
                c2.Id = c.Id;
                list.Add(c2);
            }
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
