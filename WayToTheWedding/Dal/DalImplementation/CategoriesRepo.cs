using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class CategoriesRepo : ICategoriesRepo
    {
        SiteContext siteContext;
        public CategoriesRepo(SiteContext siteContext)
        {
            this.siteContext = siteContext;
        }
        public List<Category> GetAll()
        {
            return siteContext.Categories.ToList();
        }

        public Category Create(Category item)
        {
            siteContext.Categories.Add(item);
            siteContext.SaveChanges();
            return item;
        }
        public Category Update(int Id, Category item)
        {
            throw new NotImplementedException();
        }
        public Category Delete(Category item)
        {
            siteContext.Categories.Remove(item);
            siteContext.SaveChanges();
            return item;
        }
    }
}
