using Bl.Bo;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBusinessRepo:Icrud<Bo.Business>
    {
        public List<Bo.Business> GetByCityAndCategory(int city, int category);
    }
}
