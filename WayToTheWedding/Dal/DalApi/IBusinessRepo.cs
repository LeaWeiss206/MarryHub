using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface IBusinessRepo:Icrud<Business>
    {
        public List<Business> GetByCityAndCategory(int city, int category);
        public Business IncrementStars(int id);
    }
}
