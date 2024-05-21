using AutoMapper;
using Bl.Bo;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bl.Profiles
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Bo.Category, Dal.Models.Category>()
                .ReverseMap();
            CreateMap<Bo.City, Dal.Models.City>()
               .ReverseMap();
            CreateMap<Bo.Business, Dal.Models.Business>()
                .ReverseMap();


        }

    }
}
